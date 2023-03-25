function AmountOfMaterialsInput() {

    let input = <HTMLInputElement>document.getElementById("amountOfMaterialsInputField");
    let amount = input.value;

    let link = document.getElementById("amountOfMaterialsLink") as HTMLElement;

    let url = "Dashboard/" + amount;

    link.setAttribute("href", url)

}