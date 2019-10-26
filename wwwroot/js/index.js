$(document).ready(function() {
  console.log("Hello Pluralsight!");

  var theForm = $("#theForm");
  theForm.hide();

  var button = $("#buyButton");
  button.on("click", function() {
    alert("Buying Item");
  });

  var listItems = $(".product-props li");
  listItems.on("click", function() {
    console.log("you clicked on " + $(this).text());
  });

  var $loginToggle = $("#loginToggle");
  var $popupForm = $(".popup-form");

  $loginToggle.on("click", function() {
    $popupForm.toggle(100);
  });
});
