$(document).ready(function () {


    $(document).on("click", ".wishlist-add", function () {

        var id = $(this).parent().parent().data('id')

        let data = { id: id };
        let count = (".wishlist-count");
  

        $.ajax({
            method: 'POST',
            url: "/Shop/AddToWishlist",
            data: {
                id: id
            },
            success: function (res) {
            
                $(count).text(res);
            }
        })
        return false;

    })


    $(document).on("click", ".delete-wishlist", function () {

        var id = $(this).parent().parent().data('id')

        let tableBody = $(".wishlist-table-body").children();
        let product = $(this).parent().parent();
        let data = { id: id };
        let count = (".wishlist-count");


        $.ajax({
            method: 'POST',
            url: "/wishlist/DeleteDataFromWishlist",
            data: data,
            success: function (res) {
                $(product).remove();
                res--;
                $(count).text(res);
            }
        })
        return false;

    })


})