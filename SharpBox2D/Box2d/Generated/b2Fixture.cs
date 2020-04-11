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

internal class b2Fixture : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2Fixture(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2Fixture obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2Fixture() {
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
          Box2dPINVOKE.delete_b2Fixture(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public b2Shape.Type GetShapeType() {
    b2Shape.Type ret = (b2Shape.Type)Box2dPINVOKE.b2Fixture_GetShapeType(swigCPtr);
    return ret;
  }

  public b2Shape GetShape() {
    global::System.IntPtr cPtr = Box2dPINVOKE.b2Fixture_GetShape__SWIG_0(swigCPtr);
    b2Shape ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Shape(cPtr, false);
    return ret;
  }

  public void SetSensor(bool sensor) {
    Box2dPINVOKE.b2Fixture_SetSensor(swigCPtr, sensor);
  }

  public bool IsSensor() {
    bool ret = Box2dPINVOKE.b2Fixture_IsSensor(swigCPtr);
    return ret;
  }

  public void SetFilterData(b2Filter filter) {
    Box2dPINVOKE.b2Fixture_SetFilterData(swigCPtr, b2Filter.getCPtr(filter));
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
  }

  public b2Filter GetFilterData() {
    b2Filter ret = new b2Filter(Box2dPINVOKE.b2Fixture_GetFilterData(swigCPtr), false);
    return ret;
  }

  public void Refilter() {
    Box2dPINVOKE.b2Fixture_Refilter(swigCPtr);
  }

  public b2Body GetBody() {
    global::System.IntPtr cPtr = Box2dPINVOKE.b2Fixture_GetBody__SWIG_0(swigCPtr);
    b2Body ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Body(cPtr, false);
    return ret;
  }

  public b2Fixture GetNext() {
    global::System.IntPtr cPtr = Box2dPINVOKE.b2Fixture_GetNext__SWIG_0(swigCPtr);
    b2Fixture ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Fixture(cPtr, false);
    return ret;
  }

  public global::System.IntPtr GetUserData() {
    global::System.IntPtr ret = Box2dPINVOKE.b2Fixture_GetUserData(swigCPtr);
    return ret;
  }

  public void SetUserData(global::System.IntPtr data) {
    Box2dPINVOKE.b2Fixture_SetUserData(swigCPtr, data);
  }

  public bool TestPoint(b2Vec2 p) {
    bool ret = Box2dPINVOKE.b2Fixture_TestPoint(swigCPtr, b2Vec2.getCPtr(p));
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool RayCast(b2RayCastOutput output, b2RayCastInput input, int childIndex) {
    bool ret = Box2dPINVOKE.b2Fixture_RayCast(swigCPtr, b2RayCastOutput.getCPtr(output), b2RayCastInput.getCPtr(input), childIndex);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetMassData(b2MassData massData) {
    Box2dPINVOKE.b2Fixture_GetMassData(swigCPtr, b2MassData.getCPtr(massData));
  }

  public void SetDensity(float density) {
    Box2dPINVOKE.b2Fixture_SetDensity(swigCPtr, density);
  }

  public float GetDensity() {
    float ret = Box2dPINVOKE.b2Fixture_GetDensity(swigCPtr);
    return ret;
  }

  public float GetFriction() {
    float ret = Box2dPINVOKE.b2Fixture_GetFriction(swigCPtr);
    return ret;
  }

  public void SetFriction(float friction) {
    Box2dPINVOKE.b2Fixture_SetFriction(swigCPtr, friction);
  }

  public float GetRestitution() {
    float ret = Box2dPINVOKE.b2Fixture_GetRestitution(swigCPtr);
    return ret;
  }

  public void SetRestitution(float restitution) {
    Box2dPINVOKE.b2Fixture_SetRestitution(swigCPtr, restitution);
  }

  public b2AABB GetAABB(int childIndex) {
    b2AABB ret = new b2AABB(Box2dPINVOKE.b2Fixture_GetAABB(swigCPtr, childIndex), false);
    return ret;
  }

}

}
