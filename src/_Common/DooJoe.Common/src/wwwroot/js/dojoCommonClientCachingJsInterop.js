export function getAppCulture() {
    try {
        return window.localStorage['AppLanguage'];
    } catch {
        return "en-US";
    }
}

export function setAppCulture(culture) {
    window.localStorage['AppLanguage'] = culture;
}

export function getActiveUserData()
{
    try {
        return JSON.parse(window.localStorage['ActiveUserData']);
    } catch {
        return JSON.parse("{}");
    }
}

export function setActiveUserData(value){
    window.localStorage['ActiveUserData'] = JSON.stringify(value);
}

export function GetDarkMode() {
    try {            
        return window.localStorage['DarkMode'];
    } catch {
        return -1;
    }
};

export function SetDarkMode(isDarkMode) {
    window.localStorage['DarkMode'] = isDarkMode;
}