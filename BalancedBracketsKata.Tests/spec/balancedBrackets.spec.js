"use strict";

describe("BalancedBrackets", function () {
    it("Given empty string should return OK", function () {
        //---------------Set up test pack-------------------
        var input = '';
        //---------------Execute Test ----------------------
        var result = BalancedBrackets(input);
        //---------------Test Result -----------------------
        expect(result).toBe("OK");
    });
    it("Given open bracket should return FAIL", function () {
        //---------------Set up test pack-------------------
        var input = '[';
        //---------------Execute Test ----------------------
        var result = BalancedBrackets(input);
        //---------------Test Result -----------------------
        expect(result).toBe("FAIL");
    });
    it("Given closed bracket should return FAIL", function () {
        //---------------Set up test pack-------------------
        var input = ']';
        //---------------Execute Test ----------------------
        var result = BalancedBrackets(input);
        //---------------Execute Test ----------------------
        expect(result).toBe("FAIL");
    });
    it("Given open and close bracket and should return OK", function () {
        //---------------Set up test pack-------------------
        var input = '[]';
        //---------------Execute Test ----------------------
        var result = BalancedBrackets(input);
        //---------------Execute Test ----------------------
        expect(result).toBe("OK");
    });
    it("Given unbalanced brackets and should return FAIL", function () {
        //---------------Set up test pack-------------------
        var input = '[][';
        //---------------Execute Test ----------------------
        var result = BalancedBrackets(input);
        //---------------Execute Test ----------------------
        expect(result).toBe("FAIL");
    });
    it("Given balanced brackets and should return OK", function () {
        //---------------Set up test pack-------------------
        var input = '[][]';
        //---------------Execute Test ----------------------
        var result = BalancedBrackets(input);
        //---------------Execute Test ----------------------
        expect(result).toBe("OK");
    });
    it("Given balanced brackets and should return OK", function () {
        //---------------Set up test pack-------------------
        var input = '[[]]';
        //---------------Execute Test ----------------------
        var result = BalancedBrackets(input);
        //---------------Execute Test ----------------------
        expect(result).toBe("OK");
    });
});