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
         {
            id:'Fondo',
            type:'rect',
            rect:['0px','0px','1024px','444px','auto','auto'],
            fill:["rgba(71,105,163,0.46)"],
            stroke:[0,"rgba(0,0,0,1)","none"]
         },
         {
            id:'contenido',
            type:'rect',
            rect:['123px','0px','777px','444px','auto','auto'],
            fill:["rgba(238,238,238,0.00)"],
            stroke:[0,"rgb(0, 0, 0)","none"]
         }],
         symbolInstances: [

         ]
      },
   states: {
      "Base State": {
         "${_Fondo}": [
            ["style", "top", '0px'],
            ["color", "background-color", 'rgba(71,105,163,0.46)'],
            ["style", "height", '444px'],
            ["style", "left", '-6px'],
            ["style", "width", '6px']
         ],
         "${_contenido}": [
            ["style", "top", '0px'],
            ["style", "height", '444px'],
            ["color", "background-color", 'rgba(238,238,238,0.00)'],
            ["style", "left", '123px'],
            ["style", "width", '777px']
         ],
         "${_Stage}": [
            ["color", "background-color", 'rgba(255,255,255,0.00)'],
            ["style", "width", '1024px'],
            ["style", "height", '444px'],
            ["style", "overflow", 'hidden']
         ]
      }
   },
   timelines: {
      "Default Timeline": {
         fromState: "Base State",
         toState: "",
         duration: 1500,
         autoPlay: true,
         timeline: [
            { id: "eid8", tween: [ "style", "${_Fondo}", "width", '1030px', { fromValue: '6px'}], position: 0, duration: 1000 },
            { id: "eid5", tween: [ "style", "${_Fondo}", "left", '-6px', { fromValue: '-6px'}], position: 0, duration: 0 },
            { id: "eid10", tween: [ "color", "${_contenido}", "background-color", 'rgba(238,238,238,1.00)', { animationColorSpace: 'RGB', valueTemplate: undefined, fromValue: 'rgba(238,238,238,0.00)'}], position: 1000, duration: 500 }         ]
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
})(jQuery, AdobeEdge, "EDGE-586375885");
