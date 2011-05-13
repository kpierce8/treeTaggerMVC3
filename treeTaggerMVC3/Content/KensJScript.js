
/* Scripts obtained from quirkmode,com ->
* 
*/
function createCookie(name, value) {
    var date = new Date();
    date.setTime(date.getTime() + (2 *30 * 1000));
    var expires = "; expires=" + date.toGMTString();

    document.cookie = name + "=" + value + expires + "; path=/";
}

function readCookie(name) {
    var nameEQ = name + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') c = c.substring(1, c.length);
        if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
    }
    return null;
}

function eraseCookie(name) {
    createCookie(name, "", -1);
}





function GetMap2() {

// Initialize the map
   map = new Microsoft.Maps.Map(document.getElementById("mapDiv"), { credentials: "Ar0aDgj4Y-As2wCE7_iNELR306VP_gqusZtyAipfRhCrJo2_KQn4kyLminHPZbj_", mapTypeId: "r" });
}


function ClickGeocode(credentials)
{
map.getCredentials(MakeGeocodeRequest);
}
function MakeGeocodeRequest(credentials)
{
var geocodeRequest = "http://dev.virtualearth.net/REST/v1/Locations/" + document.getElementById('txtQuery').value + "?output=json&jsonp=GeocodeCallback&key=" + credentials;
CallRestService(geocodeRequest);
}

function GeocodeCallback(result)
    {
    alert("Found location: " + result.resourceSets[0].resources[0].name);
    if (result &&
    result.resourceSets &&
    result.resourceSets.length > 0 &&
    result.resourceSets[0].resources &&
    result.resourceSets[0].resources.length > 0)
        {
        // Set the map view using the returned bounding box
        var bbox = result.resourceSets[0].resources[0].bbox;
        var viewBoundaries = Microsoft.Maps.LocationRect.fromLocations(new Microsoft.Maps.Location(bbox[0], bbox[1]), new Microsoft.Maps.Location(bbox[2], bbox[3]));
        map.setView({ bounds: viewBoundaries});
        // Add a pushpin at the found location
        var location = new Microsoft.Maps.Location(result.resourceSets[0].resources[0].point.coordinates[0], result.resourceSets[0].resources[0].point.coordinates[1]);
        var pushpin = new Microsoft.Maps.Pushpin(location);
        createCookie("mylat",location["latitude"]);
        createCookie("mylong",location["longitude"]);
        map.entities.push(pushpin);
        }
    }

function CallRestService(request)
    {
    var script = document.createElement("script");
    script.setAttribute("type", "text/javascript");
    script.setAttribute("src", request);
    document.body.appendChild(script);
    }

    function getElementsByClassName(node,classname) {
        if (node.getElementsByClassName) { // use native implementation if available    
            return node.getElementsByClassName(classname);
        } else {
            return (function getElementsByClass(searchClass, node) {
                if (node == null) node = document;
                var classElements = [], els = node.getElementsByTagName("*"), elsLen = els.length, pattern = new RegExp("(^|\\s)" + searchClass + "(\\s|$)"), i, j;
                for (i = 0, j = 0; i < elsLen; i++) {
                    if (pattern.test(els[i].className)) {
                        classElements[j] = els[i]; j++; 
                      }        }        return classElements;    })(classname, node);  }}