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
         "${_u1585-4} > p:nth-child(1)": [
            ["style", "opacity", '0']
         ],
         "${_u1739-4}": [
            ["style", "opacity", '0']
         ],
         "${_u1579}": [
            ["style", "opacity", '0']
         ],
         "${_u1549-4} > p:nth-child(1)": [
            ["style", "opacity", '0']
         ],
         "${_u1546}": [
            ["style", "opacity", '0']
         ],
         "${_u1534-3}": [
            ["style", "opacity", '0']
         ],
         "${_u1544}": [
            ["style", "opacity", '0']
         ],
         "${_u1536_img}": [
            ["style", "opacity", '0']
         ],
         "${_u1584}": [
            ["style", "opacity", '0']
         ],
         "${_u1533}": [
            ["style", "opacity", '0']
         ],
         "${_u1545-4} > p:nth-child(1)": [
            ["style", "opacity", '0']
         ],
         "${_u1547-4} > p:nth-child(1)": [
            ["style", "opacity", '0']
         ],
         "${_u1586-4} > p:nth-child(1)": [
            ["style", "opacity", '0']
         ],
         "${_u1548}": [
            ["style", "opacity", '0']
         ],
         "${_u1534-5}": [
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
            { id: "eid30", tween: [ "style", "${_u1579}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid22", tween: [ "style", "${_u1549-4} > p:nth-child(1)", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid29", tween: [ "style", "${_u1547-4} > p:nth-child(1)", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid17", tween: [ "style", "${_u1739-4}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid28", tween: [ "style", "${_u1546}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid27", tween: [ "style", "${_u1544}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid21", tween: [ "style", "${_u1534-3}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid20", tween: [ "style", "${_u1534-5}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid25", tween: [ "style", "${_u1585-4} > p:nth-child(1)", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid23", tween: [ "style", "${_u1548}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid24", tween: [ "style", "${_u1545-4} > p:nth-child(1)", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid19", tween: [ "style", "${_u1584}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid26", tween: [ "style", "${_u1536_img}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid16", tween: [ "style", "${_u1533}", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 },
            { id: "eid18", tween: [ "style", "${_u1586-4} > p:nth-child(1)", "opacity", '1', { fromValue: '0.000000'}], position: 0, duration: 2000 }         ]
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
})(jQuery, AdobeEdge, "EDGE-108188255");
