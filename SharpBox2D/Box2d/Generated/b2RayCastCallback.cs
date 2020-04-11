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

internal class b2RayCastCallback : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2RayCastCallback(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2RayCastCallback obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2RayCastCallback() {
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
          Box2dPINVOKE.delete_b2RayCastCallback(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual float ReportFixture(b2Fixture fixture, b2Vec2 point, b2Vec2 normal, float fraction) {
    float ret = Box2dPINVOKE.b2RayCastCallback_ReportFixture(swigCPtr, b2Fixture.getCPtr(fixture), b2Vec2.getCPtr(point), b2Vec2.getCPtr(normal), fraction);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public b2RayCastCallback() : this(Box2dPINVOKE.new_b2RayCastCallback(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("ReportFixture", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateb2RayCastCallback_0(SwigDirectorMethodReportFixture);
    Box2dPINVOKE.b2RayCastCallback_director_connect(swigCPtr, swigDelegate0);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(b2RayCastCallback));
    return hasDerivedMethod;
  }

  private float SwigDirectorMethodReportFixture(global::System.IntPtr fixture, global::System.IntPtr point, global::System.IntPtr normal, float fraction) {
    return ReportFixture((fixture == global::System.IntPtr.Zero) ? null : new b2Fixture(fixture, false), new b2Vec2(point, false), new b2Vec2(normal, false), fraction);
  }

  public delegate float SwigDelegateb2RayCastCallback_0(global::System.IntPtr fixture, global::System.IntPtr point, global::System.IntPtr normal, float fraction);

  private SwigDelegateb2RayCastCallback_0 swigDelegate0;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(b2Fixture), typeof(b2Vec2), typeof(b2Vec2), typeof(float) };
}

}