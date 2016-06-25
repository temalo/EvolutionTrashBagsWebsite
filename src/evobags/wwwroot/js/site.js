// Write your Javascript code.
// Mega Menu

jQuery(document).ready(function () {
    $(".dropdown").hover(
      function () {
          $('.dropdown-menu', this).fadeIn("fast");
      },
      function () {
          $('.dropdown-menu', this).fadeOut("fast");
      });
});

// expand and contract questions/answers from radio button

var showans = function () {
    $(".ans").hide();
    $("#ans" + jQuery(this).val()).show();
};
$("input[type='radio']").change(showans);

