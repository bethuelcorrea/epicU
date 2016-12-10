
(function () {
    function registerEventHandlers() {
        $(document).on('click', '.btn-like[data-id]', function () {
            var postId = Number($(this).data('id'));
            actions.likePost(postId);
        });
    }

    var actions = {
        likePost: function (postId) {
            $.post(__root + 'Account/LikePost', {
                id: postId
            })
            .then(function (response) {
                console.log('success:', response);
            })
            .fail(function (xhr, status, error) {
                console.log('error: ', xhr.responseText);
            });
        }

    };

    function init() {
        registerEventHandlers();
    }
    init();

})();


(function () {
    function registerEventHandlers() {
        $(document).on('click', '.btn-unlike[data-id]', function () {
            var postId = Number($(this).data('id'));
            actions.likePost(postId);
        });
    }

    var actions = {
        likePost: function (postId) {
            $.post(__root + 'Account/UnLinkedPost', {
                id: postId
            })
            .then(function (response) {
                console.log('success:', response);
            })
            .fail(function (xhr, status, error) {
                console.log('error: ', xhr.responseText);
            });
        }

    };

    function init() {
        registerEventHandlers();
    }
    init();

})();




