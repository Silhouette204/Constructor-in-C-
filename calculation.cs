using constructorsToThis;

class calculation{

Program info = new Program();

private int lenght, width;

public calculation(int length, int width){

  this.lenght = length;
  this.width = width;
}

public int getLength(int Lenght){
    return this.lenght;  
}
public void setLength(){
  this.lenght = lenght;
}
public int getWidth(int width){ 
   return this.width;
}

public void setWidth(){
  this.width = width;
}

public int getArea(){
  return lenght * width; 
}

public int getPerimeter(){
  return 2 * (lenght + width);
}



}