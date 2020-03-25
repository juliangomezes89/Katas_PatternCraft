using System;
public interface IUnit{
 IUnitState State { get; set; }    
 bool CanMove { get; }   
 int Damage { get; }
}
public interface IUnitState{
 bool CanMove { get; set; } 
 int Damage { get; set; }
}
public class SiegeState : IUnitState{  
 public bool CanMove { get; set; }  
 public int Damage { get; set; }      
 public SiegeState()  {   this.CanMove = false;   this.Damage = 20;  }
}
public class TankState : IUnitState{  
 public bool CanMove { get; set; }  
 public int Damage { get; set; }      
 public TankState()  {   
  this.CanMove = true;   
  this.Damage = 5;  
 }
}

public class Tank : IUnit{  
 public Tank()  {   
  this.State = new TankState();   
  this.CanMove = this.State.CanMove;   
  this.Damage = this.State.Damage;  
 }  
 private IUnitState _state;  
 public IUnitState State { 
   get{return _state;} 
   set{
       this.CanMove =   value.CanMove; 
       this.Damage = value.Damage;        
       _state = value;
   } 
  }  
  public bool CanMove { get; set; }  
  public int Damage { get; set; }
}
