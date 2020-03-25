using System;
public interface IUnit{    
 int Position { get; set; }    
 void Move();    
 IMoveBehavior MoveBehavior { get; set; }
}
public interface IMoveBehavior{    
 void Move(IUnit unit);
}

public class Fly : IMoveBehavior{    
 public void Move(IUnit unit)    {        
  unit.Position += 10;     
 }
}
public class Walk : IMoveBehavior{    
 public void Move(IUnit unit)    {        
  unit.Position += 1;    
 }
}
public class Viking : IUnit{    
 public Viking()    {
  this.MoveBehavior = new Walk();
 }    
 public IMoveBehavior MoveBehavior { get; set; }    
 public int Position { get; set; }    
 public void Move()    {         
  MoveBehavior.Move(this);    
 }
}
