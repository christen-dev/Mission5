$(document).ready(function () {
    $('#quoteForm').submit(function (event) {
        event.preventDefault();
        calculateTotal();
    });
});

function calculateTotal() {
    var hours = parseFloat($('#hours').val());
    var rate = parseFloat($('#rate').val());
    var total = hours * rate;

    if (!isNaN(total) && total >= 0) {
        $('#totalOutput').val('Total: $' + total.toFixed(2));
    } else {
        $('#totalOutput').val('Please enter a valid number of hours.');
    }
}