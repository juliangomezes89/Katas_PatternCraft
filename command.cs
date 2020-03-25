using System;
using System.Collections.Generic;

public class Probe : IUnit{    
 public Queue<ICommand> Commands { get; set; }     
 public int Minerals { get; set; } 
 public Point Position { get; set; }   
 public Probe(){  
  this.Commands = new Queue<ICommand>();  
  this.Minerals = 0;  
  this.Position = new Point(); 
 }     
 public void Move(int x, int y) {  
  this.Commands.Enqueue(new MoveCommand(this, x, y)); 
 } 

  public void Gather() {  
   if(this.Minerals == 0){   
    this.Commands.Enqueue(new GatherCommand(this));  
   } else {   
    this.Commands.Dequeue();  
   } 
  }
}

public class MoveCommand : ICommand{    
  private IUnit unit;    
  private int x;    
  private int y;    
  public MoveCommand(IUnit unit, int x, int y)    {        
   this.unit = unit;        
   this.x = x;        
   this.y = y;    
  }    
  public bool CanExecute() {      
   return true;    
  }        
  public void Execute() {      
   this.unit.Position.X = x;      
   this.unit.Position.Y = y;    
  }
}

public class GatherCommand : ICommand{    
 private IUnit unit;    
 public GatherCommand(IUnit unit)    {      this.unit = unit;      }
 public bool CanExecute() {      
  if(this.unit.Minerals != 0){        
    return false;      
   }else{        
   return true;   
  }    
}
 public void Execute() {      
  if(CanExecute()){        
    this.unit.Minerals += 5;      
  }
 }
}
