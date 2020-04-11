//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Box2D {

internal class b2JointDef : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2JointDef(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2JointDef obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2JointDef() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2dPINVOKE.delete_b2JointDef(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public b2JointDef() : this(Box2dPINVOKE.new_b2JointDef(), true) {
  }

  public b2JointType type {
    set {
      Box2dPINVOKE.b2JointDef_type_set(swigCPtr, (int)value);
    } 
    get {
      b2JointType ret = (b2JointType)Box2dPINVOKE.b2JointDef_type_get(swigCPtr);
      return ret;
    } 
  }

  public global::System.IntPtr userData {
    set {
      Box2dPINVOKE.b2JointDef_userData_set(swigCPtr, value);
    } 
		get {
				System.IntPtr cPtr = Box2dPINVOKE.b2JointDef_userData_get(swigCPtr);
				return cPtr;
		}

  }

  public b2Body bodyA {
    set {
      Box2dPINVOKE.b2JointDef_bodyA_set(swigCPtr, b2Body.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2dPINVOKE.b2JointDef_bodyA_get(swigCPtr);
      b2Body ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Body(cPtr, false);
      return ret;
    } 
  }

  public b2Body bodyB {
    set {
      Box2dPINVOKE.b2JointDef_bodyB_set(swigCPtr, b2Body.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2dPINVOKE.b2JointDef_bodyB_get(swigCPtr);
      b2Body ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Body(cPtr, false);
      return ret;
    } 
  }

  public bool collideConnected {
    set {
      Box2dPINVOKE.b2JointDef_collideConnected_set(swigCPtr, value);
    } 
    get {
      bool ret = Box2dPINVOKE.b2JointDef_collideConnected_get(swigCPtr);
      return ret;
    } 
  }

}

}
