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

internal class b2DistanceJointDef : b2JointDef {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal b2DistanceJointDef(global::System.IntPtr cPtr, bool cMemoryOwn) : base(Box2dPINVOKE.b2DistanceJointDef_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2DistanceJointDef obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2dPINVOKE.delete_b2DistanceJointDef(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public b2DistanceJointDef() : this(Box2dPINVOKE.new_b2DistanceJointDef(), true) {
  }

  public void Initialize(b2Body bodyA, b2Body bodyB, b2Vec2 anchorA, b2Vec2 anchorB) {
    Box2dPINVOKE.b2DistanceJointDef_Initialize(swigCPtr, b2Body.getCPtr(bodyA), b2Body.getCPtr(bodyB), b2Vec2.getCPtr(anchorA), b2Vec2.getCPtr(anchorB));
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
  }

  public b2Vec2 localAnchorA {
    set {
      Box2dPINVOKE.b2DistanceJointDef_localAnchorA_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2dPINVOKE.b2DistanceJointDef_localAnchorA_get(swigCPtr);
      b2Vec2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public b2Vec2 localAnchorB {
    set {
      Box2dPINVOKE.b2DistanceJointDef_localAnchorB_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2dPINVOKE.b2DistanceJointDef_localAnchorB_get(swigCPtr);
      b2Vec2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public float length {
    set {
      Box2dPINVOKE.b2DistanceJointDef_length_set(swigCPtr, value);
    } 
    get {
      float ret = Box2dPINVOKE.b2DistanceJointDef_length_get(swigCPtr);
      return ret;
    } 
  }

  public float frequencyHz {
    set {
      Box2dPINVOKE.b2DistanceJointDef_frequencyHz_set(swigCPtr, value);
    } 
    get {
      float ret = Box2dPINVOKE.b2DistanceJointDef_frequencyHz_get(swigCPtr);
      return ret;
    } 
  }

  public float dampingRatio {
    set {
      Box2dPINVOKE.b2DistanceJointDef_dampingRatio_set(swigCPtr, value);
    } 
    get {
      float ret = Box2dPINVOKE.b2DistanceJointDef_dampingRatio_get(swigCPtr);
      return ret;
    } 
  }

}

}
