
//$(function () {
//    debugger;
//    //var o = $('#divStickyNotesContainer').coaStickyNote();
   
//    // Advanced demo
// var odata=   $('#divStickyNotesContainer').coaStickyNote({        
//        resizable: false,
//        availableThemes: [
//            { text: "Yellow", value: "sticky-note-yellow-theme" },
//            { text: "Green", value: "sticky-note-green-theme" },
//            { text: "Blue", value: "sticky-note-blue-theme" },
//            { text: "Pink", value: "sticky-note-pink-theme" },
//            { text: "Orange", value: "sticky-note-orange-theme" }],
//        notePosition: { top: "100px", left: "50px" },
//        noteDimension: { width: "216px", height: "102px" },
//        noteText: "New custom note box!",
//        noteHeaderText: "Note title!",
//        deleteLinkText: "X",
//        startZIndex: 50,
//        beforeCreatingNoteBox: function (note) {
//            // Want to do any thing here?
//        },
     
//        onNoteBoxCreated: function (note) {
//            debugger;
//            if (note != null) {
//                var stickynote = {
//                    text: note.settings.noteText,
//                    colour: note.settings.defaultTheme.text,
//                    width: note.settings.noteDimension.width,
//                    height: note.settings.noteDimension.height,
//                    left: note.settings.notePosition.left,
//                    top: note.settings.notePosition.top
//                }
//                $.ajax({
//                    url: "/Home/CreateStickyNote",
//                    data: stickynote,
//                    success: function (response) {
//                        debugger;
//                        note.id = response;
//                    }
//                })
//            }
//            // Let's save it on server
//        },
//        onNoteBoxHeaderUpdate: function (note) {
//            // Return false, if want to abort the request of header update.
//            // Else let's save the updated header text on server, to preserve changes.
//        },
//        onNoteBoxTextUpdate: function (note) {
//            debugger;
//            //$.ajax({
//            //    url: "/Home/UpdateStickyNote",
//            //    data: note              
//            //});
//            // We can also show confirm box here. Which is common while deleting some thing!
//            // Return false, if want to abort the request of text update.
//            // Else let's save the updated note text on server, to preserve changes.
//        },
//        onNoteBoxDelete: function (note) {
//            // Return false, if want to abort the note delete request .
//            // Else let's delete the note details from server, to preserve changes.
//        },
//        onNoteBoxResizeStop: function (note) {
//            // Note box dimension got changed.
//            // let's save the updated dimension(width/ height) on server, to preserve changes.
//        },
//        onNoteBoxDraggingStop: function (note) {
//            debugger;
//            var note = {
//                id:note.id,
//                text: note.settings.noteText,
//                top:note.settings.notePosition.top,
//                left:note.settings.notePosition.left,
//                height:note.settings.noteDimension.height,
//                width:note.settings.noteDimension.width,
//                colour:note.settings.defaultTheme.text
//            }
           
//            $.ajax({
//                url: "/Home/UpdateStickyNote",
//                data: note
//            });
//            // Note box position got changed.
//            // let's save the updated position(top/ left) on server, to preserve changes.
//        },
//        onThemeSelectionChange: function (note) {
//            debugger;
//            // Note box theme got changed.
//            // let's save the updated theme on server, to preserve changes.
//        },
//        onMovingNoteBoxOnTop: function (note) {
//            // Note box z-index got changed to be on top of all the notes.
//            // let's save the updated the z-index on server, to preserve changes.
//        }
//    });
      
//    getLocalStickyNoteObject()


//    function getBackEndStickyObject(note) {
//        return {
//            Title: note.settings.noteHeaderText,
//            NoteText: note.settings.noteText,
//            PositionTop: note.settings.notePosition.top,
//            PositionLeft: note.settings.notePosition.left,
//            DimensionWidth: note.settings.noteDimension.width,
//            DimensionHeight: note.settings.noteDimension.height,
//            ZIndex: note.settings.zIndex,
//            OuterCssClass: note.settings.defaultTheme.value,
//            Id: note.id,
//			Index: note.index
//        };
//    }
   

//    function getLocalStickyNoteObject(backEndObj, note) {
//        debugger;
//        //var ob = $.CoaStickyNote();       
//        var StickyNotes = JSON.parse($("#stickyNotes").val());
//        if (note == null) {
//            note = {};
//            note.settings = {};
//            note.settings.notePosition = {};
//            note.settings.defaultTheme = {};
//            note.settings.noteDimension = {};
//        }
//        StickyNotes.forEach(function (e, i) {
//            // note.settings.noteHeaderText = backEndObj.Title;
//            note.settings.noteText = e.Text;
//            note.settings.notePosition.top = e.Top;
//            note.settings.notePosition.left = e.Left;
//            note.settings.noteDimension.width = e.Width;
//            note.settings.noteDimension.height = e.Height;
//            note.id = e.Id;
//            // note.settings.zIndex = backEndObj.ZIndex;
//            note.settings.defaultTheme.value = "sticky-note-" + e.Colour.toLowerCase() + "-theme";
//            //note.index = backEndObj.index;
//            $("#divStickyNotesContainer").data('coaStickyNote').loadExistingNote(note);
//        });
        
//    }


   
//});


//$(document).ready(function () {
//    $(".each-sticky-note-options #stivky1").click(function () {
//        debugger;
//    });
//});