$(document).ready(function () {   
    var init = true;
    var _row = "";
   $("#submit").click(function () {       
       if ($("#submit").val() == "Update") {
           var td = _row.children;
           td[0].innerText = $("#fname").val();
           td[1].innerText = $("#lname").val();
           td[2].innerText = $("#age").val();
       }
       else {
           if (init == true) {
               var result = $(".table");
               var defaulthtml = result.append("<table id='data'><tr><td>FirstName</td><td>LastName</td><td>Age</td></tr></table>");
               init = false;
           }
           if ($("#fname").val() != "" && $("#lname").val() != "" && $("#age").val() != "") {
               $("#data").append("<tr><td>" + $("#fname").val() + "</td>" + "<td>" + $("#lname").val() + "</td>" + "<td>" + $("#age").val() + "</td><td><button type='button' id='deleterow'><span class='glyphicon glyphicon-remove' /></button></td><td><button type='button'id='editrow'><span class='glyphicon glyphicon-edit' /></button></td></tr>");
           }
       }
       clear();
   });

   $(document).on("click","#deleterow", function () {
       this.parentElement.parentElement.remove();
   })


   $(document).on("click", "#editrow", function () {
       _row = this.parentElement.parentElement;
       var td = _row.children;
       $("#fname").val(td[0].innerText);
       $("#lname").val(td[1].innerText);
       $("#age").val(td[2].innerText);
       $("#submit").val("Update");
   });

    clear=function(){
        $("#fname").val("");
        $("#lname").val("");
        $("#age").val("");
    };
})