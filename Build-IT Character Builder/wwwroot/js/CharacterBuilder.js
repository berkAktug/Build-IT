let Character = function (race, gender, attributes, background, className, proficiencies) {

    this.race = race;
    this.gender = gender;
    this.attributes = attributes;
    this.background = background;
    this.className = className;
    this.proficiencies = proficiencies;
}

let CharacterBuilder = function () {

    let race;
    let gender;
    let attributes;
    let background;
    let className;
    let proficiencies;

    return {
        setRace: function (race) {
            this.race = race;
            return this;
        },
        setGender: function (gender) {
            this.gender = gender;
            return this;
        },
        setAttributes: function (attributes) {
            this.attributes = attributes;
            return this;
        },
        setBackground: function (background) {
            this.background = background;
            return this;
        },
        setClass: function (className) {
            this.className = className;
            return this;
        },
        setProficiency: function (proficiencies) {
            this.proficiencies = proficiencies;
            return this;
        },
        build: function () {
            return new Character(race, gender, attributes, background, className, proficiencies);
        }
    };
};

