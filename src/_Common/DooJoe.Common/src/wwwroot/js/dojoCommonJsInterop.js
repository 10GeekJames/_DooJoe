export function showPrompt(message) {
  return prompt(message, 'Type anything here');
}

export function importCommonCss() {
  var link = document.createElement("link");
  link.type = "text/css";
  link.rel = "stylesheet";
  link.media = "screen,print";
  link.href = "./_content/DooJoe.Common/app.css";
  document.getElementsByTagName("head")[0].appendChild(link);
}

export function importCommonJsInterop() {
  var link = document.createElement("link");
  link.href = "/js/dojoCommonJsInterop.js";
  link.type = "text/javascript";
  link.rel = "script";
  link.media = "screen,print";
}

export function importClientCachingJsInterop() {
  var link = document.createElement("link");
  link.href = "/js/dojoCommonClientCachingJsInterop.js";
  link.type = "text/javascript";
  link.rel = "script";
  link.media = "screen,print";
}



