// Creating functions for the Unity
mergeInto(LibraryManager.library, {
   // Function with the text param
   OpenURL_CreateNode: function (url, target) {
      // Convert bytes to the text
      var convertedURL = Pointer_stringify(url);
      var convertedTarget = Pointer_stringify(target);
      
      var link = document.createElement("a");
      link.href = convertedURL;
      link.target = target;

      link.click();
      link.remove();
   },

   OpenURL_WindowOpen: function(url)
   {
      var convertedURL = Pointer_stringify(url);
      window.open(convertedURL);
   }
});