function TSButton() {
    var name = "Fred";
    document.getElementById("ts-example").innerHTML = greeter(user);
}
var Student = /** @class */ (function () {
    function Student(firstName, middleInitial, lastName) {
        this.firstName = firstName;
        this.middleInitial = middleInitial;
        this.lastName = lastName;
        this.fullName = firstName + " " + middleInitial + " " + lastName;
    }
    return Student;
}());
function greeter(person) {
    var message = "Hello, " + person.firstName + " " + person.lastName;
    return "Welcome to the Planck energy app";
}
var user = new Student("Fred", "M.", "Smith");
//# sourceMappingURL=greeter.js.map