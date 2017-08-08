"use strict";

function BalancedBrackets(input) {
    var bracketBalanceCount = 0;
    var arrayOfBrackets = Array.from(input);
    arrayOfBrackets.forEach(function (bracket) {
        if (CheckForOpenBracket(bracket))
            bracketBalanceCount++;
        else
            bracketBalanceCount--;
        if (CheckIfBracketBalanceCount(bracketBalanceCount))
            return 'FAIL';
    });
    return CheckIfBracketBalanceCountIsZero(bracketBalanceCount);
}

function CheckForOpenBracket(bracket) {
    return bracket === '[';
}

function CheckIfBracketBalanceCountIsZero(bracketBalanceCount) {
    return bracketBalanceCount === 0 ? 'OK' : 'FAIL';
}

function CheckIfBracketBalanceCount(bracketBalanceCount) {
    return bracketBalanceCount < 0;
}