$(document).ready(function() {
  console.log("Hello Pluralsight!");

  var theForm = $("#theForm");
  theForm.hide();

  
  var productInfo = $(".product-props li");
        productInfo.on("click", function() {
    console.log("you clicked on " + $(this).text());
  });

  var $loginToggle = $("#loginToggle");
  var $popupForm = $(".popup-form");

  $loginToggle.on("click", function() {
    $popupForm.toggle(100 );
  });


    var buyButton = $(".product-info button");
    buyButton.on("click",
        function() {

            alert("Buying Item");
        });
});
