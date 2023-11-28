


function AnnouncemnetViewModel() {
    self = this;

    self.cardList = ko.observableArray([]);

    self.addCard = function () {
        var textareaValue = document.getElementById('summernote').value;
        var cardContainer = document.getElementById('cardContainer');
  
        if (!textareaValue) {
            Swal.fire({
                icon: 'warning',
                title: 'warning',
                text: ' Please enter a value'
            });
            return;
        }

        var card = document.createElement('div');
        card.classList.add('card', 'col-md-4', 'mt-3');

        var newDiv = document.createElement('div');
        newDiv.innerHTML = textareaValue;

        card.appendChild(newDiv);
        cardContainer.appendChild(card);

        self.cardList.push(textareaValue);

        document.getElementById('summernote').value = '';
        $('#summernote').summernote('code', '');
    };
    /*if (!(self.cardList().lenght>0)) {
            Swal.fire({
                icon: 'warning',
                title: 'warning',
                text: ' Please enter a value'
            });
            return;
        }*/
    self.saveAnnouncement = function () {
        
        $.ajax({
            type: "POST",
            url: "/admin/Announcement/SaveAnnouncement",
            data: { announcement: ko.toJS(self.cardList) },
            type: 'post',
            cache: false,
            success: function (result) {
                if (result === true) {

                    Swal.fire({
                        icon: 'warning',
                        title: 'Uyarý',
                        text:' Operation successful'
                    });
                } else {
                    
                }
            },
            error: function () {
                alert("Hata oluþtu.");
            }
        });


    };
    function htmlDecode(input) {
        var doc = new DOMParser().parseFromString(input, "text/html");
        return doc.documentElement.textContent;
    }
}

var viewModel = new AnnouncemnetViewModel();
ko.applyBindings(viewModel);