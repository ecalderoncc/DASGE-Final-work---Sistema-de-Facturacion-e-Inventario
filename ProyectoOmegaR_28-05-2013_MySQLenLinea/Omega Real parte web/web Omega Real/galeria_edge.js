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
         "${_u1738-4}": [
            ["style", "opacity", '0']
         ],
         "${_u1663-4} > p:nth-child(1)": [
            ["style", "opacity", '0']
         ],
         "${_u1666-4} > p:nth-child(1)": [
            ["style", "opacity", '0']
         ],
         "${_u1676-4} > p:nth-child(1)": [
            ["style", "opacity", '0']
         ],
         "${_u1672_img}": [
            ["style", "opacity", '0']
         ],
         "${_u1700_img}": [
            ["style", "opacity", '0']
         ],
         "${_u1665-4} > p:nth-child(1)": [
            ["style", "opacity", '0']
         ],
         "${_u1670_img}": [
            ["style", "opacity", '0']
         ],
         "${_u1674_img}": [
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
            { id: "eid11", tween: [ "style", "${_u1663-4} > p:nth-child(1)", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid12", tween: [ "style", "${_u1672_img}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid17", tween: [ "style", "${_u1670_img}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid10", tween: [ "style", "${_u1676-4} > p:nth-child(1)", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid16", tween: [ "style", "${_u1674_img}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid14", tween: [ "style", "${_u1738-4}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid18", tween: [ "style", "${_u1700_img}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid13", tween: [ "style", "${_u1665-4} > p:nth-child(1)", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid15", tween: [ "style", "${_u1666-4} > p:nth-child(1)", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 }         ]
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
})(jQuery, AdobeEdge, "EDGE-108104805");
