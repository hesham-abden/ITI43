$("#btnAdd").click(()=>{
    if($("#taskInput").val()!=""){
temprow=$("<div></div>");
temprow.appendTo(".tasksBox");

let taskBar=$("<p></p>");
taskBar.text($("#taskInput").val());
taskBar.addClass("task");
taskBar.appendTo(temprow);
let doneBtn=$("<button>Done</button>")
doneBtn.addClass("done");
doneBtn.appendTo(temprow);
let deleteBtn=$("<button>Delete</button>")
deleteBtn.addClass("delete");
deleteBtn.appendTo(temprow);

doneBtn.click(function(){
    $(this).parent().toggleClass("TaskDone")
});
deleteBtn.click(function(){
    $(this).parent().remove();
})

    }
});
