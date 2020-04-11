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

internal class b2Body : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2Body(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2Body obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2Body() {
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
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public b2Fixture CreateFixture(b2FixtureDef def) {
    global::System.IntPtr cPtr = Box2dPINVOKE.b2Body_CreateFixture__SWIG_0(swigCPtr, b2FixtureDef.getCPtr(def));
    b2Fixture ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Fixture(cPtr, false);
    return ret;
  }

  public b2Fixture CreateFixture(b2Shape shape, float density) {
    global::System.IntPtr cPtr = Box2dPINVOKE.b2Body_CreateFixture__SWIG_1(swigCPtr, b2Shape.getCPtr(shape), density);
    b2Fixture ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Fixture(cPtr, false);
    return ret;
  }

  public void DestroyFixture(b2Fixture fixture) {
    Box2dPINVOKE.b2Body_DestroyFixture(swigCPtr, b2Fixture.getCPtr(fixture));
  }

  public void SetTransform(b2Vec2 position, float angle) {
    Box2dPINVOKE.b2Body_SetTransform(swigCPtr, b2Vec2.getCPtr(position), angle);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
  }

  public b2Transform GetTransform() {
    b2Transform ret = new b2Transform(Box2dPINVOKE.b2Body_GetTransform(swigCPtr), false);
    return ret;
  }

  public b2Vec2 GetPosition() {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2Body_GetPosition(swigCPtr), false);
    return ret;
  }

  public float GetAngle() {
    float ret = Box2dPINVOKE.b2Body_GetAngle(swigCPtr);
    return ret;
  }

  public b2Vec2 GetWorldCenter() {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2Body_GetWorldCenter(swigCPtr), false);
    return ret;
  }

  public b2Vec2 GetLocalCenter() {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2Body_GetLocalCenter(swigCPtr), false);
    return ret;
  }

  public void SetLinearVelocity(b2Vec2 v) {
    Box2dPINVOKE.b2Body_SetLinearVelocity(swigCPtr, b2Vec2.getCPtr(v));
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
  }

  public b2Vec2 GetLinearVelocity() {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2Body_GetLinearVelocity(swigCPtr), false);
    return ret;
  }

  public void SetAngularVelocity(float omega) {
    Box2dPINVOKE.b2Body_SetAngularVelocity(swigCPtr, omega);
  }

  public float GetAngularVelocity() {
    float ret = Box2dPINVOKE.b2Body_GetAngularVelocity(swigCPtr);
    return ret;
  }

  public void ApplyForce(b2Vec2 force, b2Vec2 point, bool wake) {
    Box2dPINVOKE.b2Body_ApplyForce(swigCPtr, b2Vec2.getCPtr(force), b2Vec2.getCPtr(point), wake);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ApplyForceToCenter(b2Vec2 force, bool wake) {
    Box2dPINVOKE.b2Body_ApplyForceToCenter(swigCPtr, b2Vec2.getCPtr(force), wake);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ApplyTorque(float torque, bool wake) {
    Box2dPINVOKE.b2Body_ApplyTorque(swigCPtr, torque, wake);
  }

  public void ApplyLinearImpulse(b2Vec2 impulse, b2Vec2 point, bool wake) {
    Box2dPINVOKE.b2Body_ApplyLinearImpulse(swigCPtr, b2Vec2.getCPtr(impulse), b2Vec2.getCPtr(point), wake);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ApplyLinearImpulseToCenter(b2Vec2 impulse, bool wake) {
    Box2dPINVOKE.b2Body_ApplyLinearImpulseToCenter(swigCPtr, b2Vec2.getCPtr(impulse), wake);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ApplyAngularImpulse(float impulse, bool wake) {
    Box2dPINVOKE.b2Body_ApplyAngularImpulse(swigCPtr, impulse, wake);
  }

  public float GetMass() {
    float ret = Box2dPINVOKE.b2Body_GetMass(swigCPtr);
    return ret;
  }

  public float GetInertia() {
    float ret = Box2dPINVOKE.b2Body_GetInertia(swigCPtr);
    return ret;
  }

  public void GetMassData(b2MassData data) {
    Box2dPINVOKE.b2Body_GetMassData(swigCPtr, b2MassData.getCPtr(data));
  }

  public void SetMassData(b2MassData data) {
    Box2dPINVOKE.b2Body_SetMassData(swigCPtr, b2MassData.getCPtr(data));
  }

  public void ResetMassData() {
    Box2dPINVOKE.b2Body_ResetMassData(swigCPtr);
  }

  public b2Vec2 GetWorldPoint(b2Vec2 localPoint) {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2Body_GetWorldPoint(swigCPtr, b2Vec2.getCPtr(localPoint)), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public b2Vec2 GetWorldVector(b2Vec2 localVector) {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2Body_GetWorldVector(swigCPtr, b2Vec2.getCPtr(localVector)), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public b2Vec2 GetLocalPoint(b2Vec2 worldPoint) {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2Body_GetLocalPoint(swigCPtr, b2Vec2.getCPtr(worldPoint)), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public b2Vec2 GetLocalVector(b2Vec2 worldVector) {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2Body_GetLocalVector(swigCPtr, b2Vec2.getCPtr(worldVector)), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public b2Vec2 GetLinearVelocityFromWorldPoint(b2Vec2 worldPoint) {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2Body_GetLinearVelocityFromWorldPoint(swigCPtr, b2Vec2.getCPtr(worldPoint)), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public b2Vec2 GetLinearVelocityFromLocalPoint(b2Vec2 localPoint) {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2Body_GetLinearVelocityFromLocalPoint(swigCPtr, b2Vec2.getCPtr(localPoint)), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float GetLinearDamping() {
    float ret = Box2dPINVOKE.b2Body_GetLinearDamping(swigCPtr);
    return ret;
  }

  public void SetLinearDamping(float linearDamping) {
    Box2dPINVOKE.b2Body_SetLinearDamping(swigCPtr, linearDamping);
  }

  public float GetAngularDamping() {
    float ret = Box2dPINVOKE.b2Body_GetAngularDamping(swigCPtr);
    return ret;
  }

  public void SetAngularDamping(float angularDamping) {
    Box2dPINVOKE.b2Body_SetAngularDamping(swigCPtr, angularDamping);
  }

  public float GetGravityScale() {
    float ret = Box2dPINVOKE.b2Body_GetGravityScale(swigCPtr);
    return ret;
  }

  public void SetGravityScale(float scale) {
    Box2dPINVOKE.b2Body_SetGravityScale(swigCPtr, scale);
  }

  public void SetBullet(bool flag) {
    Box2dPINVOKE.b2Body_SetBullet(swigCPtr, flag);
  }

  public bool IsBullet() {
    bool ret = Box2dPINVOKE.b2Body_IsBullet(swigCPtr);
    return ret;
  }

  public void SetSleepingAllowed(bool flag) {
    Box2dPINVOKE.b2Body_SetSleepingAllowed(swigCPtr, flag);
  }

  public bool IsSleepingAllowed() {
    bool ret = Box2dPINVOKE.b2Body_IsSleepingAllowed(swigCPtr);
    return ret;
  }

  public void SetAwake(bool flag) {
    Box2dPINVOKE.b2Body_SetAwake(swigCPtr, flag);
  }

  public bool IsAwake() {
    bool ret = Box2dPINVOKE.b2Body_IsAwake(swigCPtr);
    return ret;
  }

  public void SetEnabled(bool flag) {
    Box2dPINVOKE.b2Body_SetEnabled(swigCPtr, flag);
  }

  public bool IsEnabled() {
    bool ret = Box2dPINVOKE.b2Body_IsEnabled(swigCPtr);
    return ret;
  }

  public void SetFixedRotation(bool flag) {
    Box2dPINVOKE.b2Body_SetFixedRotation(swigCPtr, flag);
  }

  public bool IsFixedRotation() {
    bool ret = Box2dPINVOKE.b2Body_IsFixedRotation(swigCPtr);
    return ret;
  }

  public b2Fixture GetFixtureList() {
    global::System.IntPtr cPtr = Box2dPINVOKE.b2Body_GetFixtureList__SWIG_0(swigCPtr);
    b2Fixture ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Fixture(cPtr, false);
    return ret;
  }

  public global::System.IntPtr GetUserData() {
    global::System.IntPtr ret = Box2dPINVOKE.b2Body_GetUserData(swigCPtr);
    return ret;
  }

  public void SetUserData(global::System.IntPtr data) {
    Box2dPINVOKE.b2Body_SetUserData(swigCPtr, data);
  }

  public b2BodyType Type {
    set {
      Box2dPINVOKE.b2Body_Type_set(swigCPtr, (int)value);
    } 
    get {
      b2BodyType ret = (b2BodyType)Box2dPINVOKE.b2Body_Type_get(swigCPtr);
      return ret;
    } 
  }

}

}
