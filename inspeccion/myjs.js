var readData = function() {

  var burl = "https://tiempo26.com/api/get_category_posts/?slug=denuncia";
   $.get({
     url: burl,
     //type: 'GET',
          dataType: 'jsonp',
          cors: true ,
          contentType:'application/json',
          secure: true,
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
    
   
    complete: function(data){
      //var obj =  JSON.parse(data);
      var obj =JSON.parse(JSON.stringify(data));
        console.log(obj);// S1000
               
           for (var i in obj){
        //    alert(obj[i]);
           } 
        
    },
    success: function(data){
        //alert(data)
    }
})

}

function stringToArray(items) {
    return JSON.parse("[" + items.replace(/'/g, '"') + "]");
} 