function AmountOfMaterialsInput() {
    var input = document.getElementById("amountOfMaterialsInputField");
    var amount = input.value;
    var link = document.getElementById("amountOfMaterialsLink");
    var url = "Dashboard/" + amount;
    link.setAttribute("href", url);
}
//# sourceMappingURL=inputs.js.map