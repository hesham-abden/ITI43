window.addEventListener("load", function () {
  let video = document.querySelector("video");
  timeBar = document.getElementById("timebar");
  let playButton = document.getElementById("Play");
  let stopButton = document.getElementById("Stop");
  let begButton = document.getElementById("Beginning");
  let endButton = document.getElementById("End");
  let forwardButton = document.getElementById("Forward");
  let backwardButton = document.getElementById("Backward");
  let muteButton = document.getElementById("Mute");
  let audioBar = document.getElementById("audiobar");
  let speedBar = document.getElementById("speedbar");
  let timeIndicator = document.querySelector("span");

  playButton.addEventListener("click", function () {
    video.play();
  });
  stopButton.addEventListener("click", function () {
    video.pause();
  });
  begButton.addEventListener("click", function () {
    video.load();
    video.currentTime = 0;
    video.play();
  });
  video.addEventListener("timeupdate", function () {
    timeBar.value = this.currentTime;
    timeIndicator.innerHTML = `
   ${Math.floor(this.currentTime / 60)
     .toString()
     .padStart(2, "0")}:
   ${Math.floor(this.currentTime % 60)
     .toString()
     .padStart(2, "0")}/
   ${Math.floor(this.duration / 60)
     .toString()
     .padStart(2, "0")}:
   ${Math.floor(this.duration % 60)
     .toString()
     .padStart(2, "0")}`;
  });
  endButton.addEventListener("click", function () {
    video.currentTime = 100;
  });
  forwardButton.addEventListener("click", function () {
    if (video.playbackRate < 16) {
      video.playbackRate += 2;
    }
  });
  backwardButton.addEventListener("click", function () {
    if (video.playbackRate > 2) {
      video.playbackRate -= 2;
    }
  });
  muteButton.addEventListener("click", function () {
    if (video.volume != 0) {
      video.volume = 0;
    } else {
      video.volume = 1;
    }
  });
  timeBar.addEventListener("change", function () {
    video.currentTime = this.value;
  });
  audioBar.addEventListener("change", function () {
    video.volume = this.value;
  });
  speedBar.addEventListener("change", function () {
    video.playbackRate = this.value;
  });
});
