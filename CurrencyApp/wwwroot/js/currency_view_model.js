function CurrencyConverterViewModel() {
    var self = this;
    self.amount = ko.observable("");

    self.currencies = ko.observableArray([
        { name: '--', rate: 0 },
       /* { name: 'EUR', rate: 30 },
        { name: 'TRY', rate: 1 }*/
    ]);

    self.fromCurrency = ko.observable(self.currencies()[0]);
    self.toCurrency = ko.observable(self.currencies()[0]);
    // self.currencies.push({ name: item, rate: data.conversion_rates[item] })
    //https://api.currencyapi.com/v3/latest?apikey=cur_live_FKhpQU4v69Noz27s2rG8bYrOV1LOeiaJuhgD1PnO
    //  self.currencies.push({ name: item, rate: data.data[item].value })
    //https://api.currencyapi.com/v3/latest?apikey=cur_live_FKhpQU4v69Noz27s2rG8bYrOV1LOeiaJuhgD1PnO
    $.ajax({
        url: 'https://api.currencyapi.com/v3/latest?apikey=cur_live_FKhpQU4v69Noz27s2rG8bYrOV1LOeiaJuhgD1PnO',
        dataType: 'json',
        success: function (data) {
           // console.log(data.conversion_rates['AED']);
            for (var item in data.data) {
               // console.log(item);
                self.currencies.push({ name: item, rate: data.data[item].value })
            }
        },
        error: function (error) {
            console.error('API error:', error);
        }
    });
    self.convertedAmount = ko.computed(function () {
        var fromRate = self.fromCurrency().rate;
        var toRate = self.toCurrency().rate;
        var amount = self.amount();

        if (fromRate && toRate && amount) {
            return (amount * fromRate / toRate).toFixed(2);
        } else {
            return 0;
        }
    });
}

ko.applyBindings(new CurrencyConverterViewModel());

/**/