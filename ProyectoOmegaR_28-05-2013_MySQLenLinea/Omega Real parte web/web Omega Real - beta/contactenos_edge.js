/**
 * Adobe Edge: symbol definitions
 */
(function($, Edge, compId){
//images folder
var im='images/';

var fonts = {};


var resources = [
];
var symbols = {
"stage": {
   version: "1.5.0",
   minimumCompatibleVersion: "1.5.0",
   build: "1.5.0.217",
   baseState: "Base State",
   initialState: "Base State",
   gpuAccelerate: false,
   resizeInstances: false,
   content: {
         dom: [
],
         symbolInstances: [

         ]
      },
   states: {
      "Base State": {
         "${_u903-4}": [
            ["style", "opacity", '0']
         ],
         "${_nombre}": [
            ["transform", "translateY", '2px'],
            ["style", "opacity", '0']
         ],
         "${_u898-4} > span:nth-child(1)": [
            ["transform", "translateY", '2px'],
            ["style", "opacity", '0']
         ],
         "${_u912-4}": [
            ["transform", "translateY", '2px'],
            ["style", "opacity", '0']
         ],
         "${_u902-4} > span:nth-child(1)": [
            ["transform", "translateY", '2px'],
            ["style", "opacity", '0']
         ],
         "${_u879-4}": [
            ["style", "opacity", '0']
         ],
         "${_u880-4} > span:nth-child(1)": [
            ["transform", "translateY", '2px'],
            ["style", "opacity", '0']
         ],
         "${_widgetu900}": [
            ["style", "opacity", '1']
         ],
         "${_u899-4}": [
            ["transform", "translateX", '2px'],
            ["style", "opacity", '0']
         ],
         "${_widgetu876}": [
            ["transform", "translateX", '2px'],
            ["style", "opacity", '1']
         ],
         "${_u927_img}": [
            ["transform", "translateY", '2px'],
            ["style", "opacity", '0']
         ],
         "${_correo}": [
            ["style", "opacity", '0'],
            ["transform", "translateY", '2px'],
            ["transform", "translateX", '2px']
         ],
         "${_u935}": [
            ["transform", "translateY", '2px'],
            ["style", "opacity", '0']
         ],
         "${_u936}": [
            ["transform", "translateY", '2px'],
            ["style", "opacity", '0']
         ],
         "${_u905-17}": [
            ["transform", "translateY", '2px'],
            ["style", "opacity", '0']
         ],
         "${_mensaje}": [
            ["style", "opacity", '0'],
            ["transform", "translateY", '2px'],
            ["transform", "translateX", '2px']
         ]
      }
   },
   timelines: {
      "Default Timeline": {
         fromState: "Base State",
         toState: "",
         duration: 2000,
         autoPlay: true,
         timeline: [
            { id: "eid71", tween: [ "style", "${_u899-4}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid58", tween: [ "style", "${_nombre}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid66", tween: [ "transform", "${_mensaje}", "translateX", '2px', { fromValue: '2px'}], position: 0, duration: 0 },
            { id: "eid62", tween: [ "style", "${_correo}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid65", tween: [ "transform", "${_correo}", "translateX", '2px', { fromValue: '2px'}], position: 0, duration: 0 },
            { id: "eid57", tween: [ "style", "${_u927_img}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid73", tween: [ "style", "${_u903-4}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid59", tween: [ "style", "${_mensaje}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid56", tween: [ "style", "${_u912-4}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid61", tween: [ "style", "${_u898-4} > span:nth-child(1)", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid69", tween: [ "style", "${_u879-4}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid55", tween: [ "style", "${_u936}", "opacity", '0.5', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid64", tween: [ "style", "${_u905-17}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid60", tween: [ "style", "${_u902-4} > span:nth-child(1)", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid63", tween: [ "style", "${_u880-4} > span:nth-child(1)", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid54", tween: [ "style", "${_u935}", "opacity", '0.5', { fromValue: '0.000000'}], position: 0, duration: 2000 }         ]
      }
   }
}
};


Edge.registerCompositionDefn(compId, symbols, fonts, resources);

/**
 * Adobe Edge DOM Ready Event Handler
 */
$(window).ready(function() {
     Edge.launchComposition(compId);
});
})(jQuery, AdobeEdge, "EDGE-119096630");
