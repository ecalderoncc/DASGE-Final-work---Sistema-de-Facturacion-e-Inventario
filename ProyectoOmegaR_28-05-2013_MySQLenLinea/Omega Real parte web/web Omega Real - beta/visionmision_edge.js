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
         "${_u940}": [
            ["style", "opacity", '0.5']
         ],
         "${_u943}": [
            ["style", "opacity", '0.5']
         ],
         "${_u850-8}": [
            ["style", "opacity", '0']
         ],
         "${_u938}": [
            ["style", "opacity", '0.5']
         ],
         "${_u941}": [
            ["style", "opacity", '0.5']
         ],
         "${_u939}": [
            ["style", "opacity", '0.5']
         ],
         "${_u942}": [
            ["style", "opacity", '0.5']
         ],
         "${_u850-2}": [
            ["style", "opacity", '0']
         ],
         "${_u850-5}": [
            ["style", "opacity", '0']
         ],
         "${_u861_img}": [
            ["style", "opacity", '0']
         ],
         "${_u850-11}": [
            ["style", "opacity", '0']
         ],
         "${_u849-4}": [
            ["style", "opacity", '0']
         ],
         "${_u856_img}": [
            ["style", "opacity", '0']
         ],
         "${_u866_img}": [
            ["style", "opacity", '0']
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
            { id: "eid16", tween: [ "style", "${_u850-11}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid15", tween: [ "style", "${_u861_img}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid12", tween: [ "style", "${_u856_img}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid9", tween: [ "style", "${_u850-2}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid14", tween: [ "style", "${_u866_img}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid10", tween: [ "style", "${_u849-4}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid11", tween: [ "style", "${_u850-8}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid13", tween: [ "style", "${_u850-5}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 }         ]
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
})(jQuery, AdobeEdge, "EDGE-107602093");
