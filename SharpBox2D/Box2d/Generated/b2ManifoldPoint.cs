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

internal class b2ManifoldPoint : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2ManifoldPoint(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2ManifoldPoint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2ManifoldPoint() {
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
          Box2dPINVOKE.delete_b2ManifoldPoint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public b2Vec2 localPoint {
    set {
      Box2dPINVOKE.b2ManifoldPoint_localPoint_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2dPINVOKE.b2ManifoldPoint_localPoint_get(swigCPtr);
      b2Vec2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public float normalImpulse {
    set {
      Box2dPINVOKE.b2ManifoldPoint_normalImpulse_set(swigCPtr, value);
    } 
    get {
      float ret = Box2dPINVOKE.b2ManifoldPoint_normalImpulse_get(swigCPtr);
      return ret;
    } 
  }

  public float tangentImpulse {
    set {
      Box2dPINVOKE.b2ManifoldPoint_tangentImpulse_set(swigCPtr, value);
    } 
    get {
      float ret = Box2dPINVOKE.b2ManifoldPoint_tangentImpulse_get(swigCPtr);
      return ret;
    } 
  }

  public b2ManifoldPoint() : this(Box2dPINVOKE.new_b2ManifoldPoint(), true) {
  }

}

}
