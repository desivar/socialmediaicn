@import url('https://fonts.googleapis.com/css2?family=Poppins:wght@200;300;400;500;600;700&display=swap');
*{
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: 'Poppins', sans-serif;
}
html,body{
  display: grid;
  height: 100%;
  place-items: center;
  background: #ecf0f3;
}
.icons a{
  background: #ecf0f3;
  position: relative;
  height: 60px;
  width: 60px;
  margin: 0 10px;
  display: inline-flex;
  text-decoration: none;
  border-radius: 50%;
  transition: all 0.3s;
  box-shadow: -3px -3px 7px #ffffff,
              3px 3px 5px #ceced1;
}
.icons a:hover:before{
  content: "";
  position: absolute;
  top: 0;
  left: 0;
  bottom: 0;
  right: 0;
  border-radius: 50%;
  background: #ecf0f3;
  box-shadow: inset -3px -3px 7px #ffffff,
              inset 3px 3px 5px #ceced1;
}
.icons a i{
  position: relative;
  z-index: 3;
  text-align: center;
  width: 100%;
  height: 100%;
  font-size: 25px;
  line-height: 60px;
}
.icons a:hover i{
  transform: scale(0.9);
}
.icons a.fb i{
  color: #4267B2;
}
.icons a.twitter i{
  color: #1DA1F2;
}
.icons a.insta i{
  color: #E1306C;
}
.icons a.git i{
  color: #333;
}
.icons a.yt i{
  color: #ff0000;
}