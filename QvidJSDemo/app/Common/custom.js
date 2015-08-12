mainApp.directive('student', function () {
    //define the directive object
    var directive = {};
    //restrict = E, signifies that directive is Element directive
    directive.restrict = 'E';
    //template replaces the complete element with its text. 
    directive.template = "I am custom directive.";
    
    return directive;
});