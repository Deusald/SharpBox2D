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

internal class b2GearJoint : b2Joint {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal b2GearJoint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(Box2dPINVOKE.b2GearJoint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2GearJoint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2dPINVOKE.delete_b2GearJoint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override b2Vec2 GetAnchorA() {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2GearJoint_GetAnchorA(swigCPtr), true);
    return ret;
  }

  public override b2Vec2 GetAnchorB() {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2GearJoint_GetAnchorB(swigCPtr), true);
    return ret;
  }

  public override b2Vec2 GetReactionForce(float inv_dt) {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2GearJoint_GetReactionForce(swigCPtr, inv_dt), true);
    return ret;
  }

  public override float GetReactionTorque(float inv_dt) {
    float ret = Box2dPINVOKE.b2GearJoint_GetReactionTorque(swigCPtr, inv_dt);
    return ret;
  }

  public b2Joint GetJoint1() {
    global::System.IntPtr cPtr = Box2dPINVOKE.b2GearJoint_GetJoint1(swigCPtr);
    b2Joint ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Joint(cPtr, false);
    return ret;
  }

  public b2Joint GetJoint2() {
    global::System.IntPtr cPtr = Box2dPINVOKE.b2GearJoint_GetJoint2(swigCPtr);
    b2Joint ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Joint(cPtr, false);
    return ret;
  }

  public void SetRatio(float ratio) {
    Box2dPINVOKE.b2GearJoint_SetRatio(swigCPtr, ratio);
  }

  public float GetRatio() {
    float ret = Box2dPINVOKE.b2GearJoint_GetRatio(swigCPtr);
    return ret;
  }

}

}
