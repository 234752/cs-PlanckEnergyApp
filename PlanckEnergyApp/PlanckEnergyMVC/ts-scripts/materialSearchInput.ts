function MaterialSearchInput() {

    let input = <HTMLInputElement>document.getElementById("materialSearchInputField");

    let materialName = input.value;

    let link = document.getElementById("materialSearchLink") as HTMLElement;

    link.setAttribute("href", materialName)

}