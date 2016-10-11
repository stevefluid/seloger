/**
 * Add by Steven : add new js file
 * + store console.log string value in logMessage var
 */

if (undefined === window.NS) {
	window.NS = {};
}	

window.NS.defaultMessage = 'I\'m an Amazing WebApp, ';

window.NS.logMessage = function(message, prepend){
	var localMessage = prepend ? window.NS.defaultMessage+message : message;
	console.log( localMessage );
};
