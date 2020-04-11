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

internal class Box2d {
  public static b2Vec2 new_b2Vec2Array(int nelements) {
    global::System.IntPtr cPtr = Box2dPINVOKE.new_b2Vec2Array(nelements);
    b2Vec2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
    return ret;
  }

  public static void delete_b2Vec2Array(b2Vec2 ary) {
    Box2dPINVOKE.delete_b2Vec2Array(b2Vec2.getCPtr(ary));
  }

  public static b2Vec2 b2Vec2Array_getitem(b2Vec2 ary, int index) {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2Vec2Array_getitem(b2Vec2.getCPtr(ary), index), true);
    return ret;
  }

  public static void b2Vec2Array_setitem(b2Vec2 ary, int index, b2Vec2 value) {
    Box2dPINVOKE.b2Vec2Array_setitem(b2Vec2.getCPtr(ary), index, b2Vec2.getCPtr(value));
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
  }

  public static b2Version b2_version {
    set {
      Box2dPINVOKE.b2_version_set(b2Version.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2dPINVOKE.b2_version_get();
      b2Version ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Version(cPtr, false);
      return ret;
    } 
  }

  public static b2Vec2 b2Vec2_zero {
    get {
      global::System.IntPtr cPtr = Box2dPINVOKE.b2Vec2_zero_get();
      b2Vec2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public static float b2Dot(b2Vec2 a, b2Vec2 b) {
    float ret = Box2dPINVOKE.b2Dot__SWIG_0(b2Vec2.getCPtr(a), b2Vec2.getCPtr(b));
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static float b2Cross(b2Vec2 a, b2Vec2 b) {
    float ret = Box2dPINVOKE.b2Cross__SWIG_0(b2Vec2.getCPtr(a), b2Vec2.getCPtr(b));
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static b2Vec2 b2Cross(b2Vec2 a, float s) {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2Cross__SWIG_1(b2Vec2.getCPtr(a), s), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static b2Vec2 b2Cross(float s, b2Vec2 a) {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2Cross__SWIG_2(s, b2Vec2.getCPtr(a)), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static b2Vec2 Plus(b2Vec2 a, b2Vec2 b) {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.Plus__SWIG_0(b2Vec2.getCPtr(a), b2Vec2.getCPtr(b)), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static b2Vec2 Minus(b2Vec2 a, b2Vec2 b) {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.Minus__SWIG_0(b2Vec2.getCPtr(a), b2Vec2.getCPtr(b)), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static b2Vec2 Multiply(float s, b2Vec2 a) {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.Multiply__SWIG_0(s, b2Vec2.getCPtr(a)), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool EqualEqual(b2Vec2 a, b2Vec2 b) {
    bool ret = Box2dPINVOKE.EqualEqual(b2Vec2.getCPtr(a), b2Vec2.getCPtr(b));
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool NotEqual(b2Vec2 a, b2Vec2 b) {
    bool ret = Box2dPINVOKE.NotEqual(b2Vec2.getCPtr(a), b2Vec2.getCPtr(b));
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static float b2Distance(b2Vec2 a, b2Vec2 b) {
    float ret = Box2dPINVOKE.b2Distance__SWIG_0(b2Vec2.getCPtr(a), b2Vec2.getCPtr(b));
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static float b2DistanceSquared(b2Vec2 a, b2Vec2 b) {
    float ret = Box2dPINVOKE.b2DistanceSquared(b2Vec2.getCPtr(a), b2Vec2.getCPtr(b));
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static b2Vec3 Multiply(float s, b2Vec3 a) {
    b2Vec3 ret = new b2Vec3(Box2dPINVOKE.Multiply__SWIG_1(s, b2Vec3.getCPtr(a)), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static b2Vec3 Plus(b2Vec3 a, b2Vec3 b) {
    b2Vec3 ret = new b2Vec3(Box2dPINVOKE.Plus__SWIG_1(b2Vec3.getCPtr(a), b2Vec3.getCPtr(b)), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static b2Vec3 Minus(b2Vec3 a, b2Vec3 b) {
    b2Vec3 ret = new b2Vec3(Box2dPINVOKE.Minus__SWIG_1(b2Vec3.getCPtr(a), b2Vec3.getCPtr(b)), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static float b2Dot(b2Vec3 a, b2Vec3 b) {
    float ret = Box2dPINVOKE.b2Dot__SWIG_1(b2Vec3.getCPtr(a), b2Vec3.getCPtr(b));
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static b2Vec3 b2Cross(b2Vec3 a, b2Vec3 b) {
    b2Vec3 ret = new b2Vec3(Box2dPINVOKE.b2Cross__SWIG_3(b2Vec3.getCPtr(a), b2Vec3.getCPtr(b)), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static b2Vec2 b2Min(b2Vec2 a, b2Vec2 b) {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2Min(b2Vec2.getCPtr(a), b2Vec2.getCPtr(b)), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static b2Vec2 b2Max(b2Vec2 a, b2Vec2 b) {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2Max(b2Vec2.getCPtr(a), b2Vec2.getCPtr(b)), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static b2Vec2 b2Clamp(b2Vec2 a, b2Vec2 low, b2Vec2 high) {
    b2Vec2 ret = new b2Vec2(Box2dPINVOKE.b2Clamp(b2Vec2.getCPtr(a), b2Vec2.getCPtr(low), b2Vec2.getCPtr(high)), true);
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool b2TestOverlap(b2Shape shapeA, int indexA, b2Shape shapeB, int indexB, b2Transform xfA, b2Transform xfB) {
    bool ret = Box2dPINVOKE.b2TestOverlap__SWIG_0(b2Shape.getCPtr(shapeA), indexA, b2Shape.getCPtr(shapeB), indexB, b2Transform.getCPtr(xfA), b2Transform.getCPtr(xfB));
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool b2TestOverlap(b2AABB a, b2AABB b) {
    bool ret = Box2dPINVOKE.b2TestOverlap__SWIG_1(b2AABB.getCPtr(a), b2AABB.getCPtr(b));
    if (Box2dPINVOKE.SWIGPendingException.Pending) throw Box2dPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static float b2MixFriction(float friction1, float friction2) {
    float ret = Box2dPINVOKE.b2MixFriction(friction1, friction2);
    return ret;
  }

  public static float b2MixRestitution(float restitution1, float restitution2) {
    float ret = Box2dPINVOKE.b2MixRestitution(restitution1, restitution2);
    return ret;
  }

  public static void b2Distance(b2DistanceOutput output, b2SimplexCache cache, b2DistanceInput input) {
    Box2dPINVOKE.b2Distance__SWIG_1(b2DistanceOutput.getCPtr(output), b2SimplexCache.getCPtr(cache), b2DistanceInput.getCPtr(input));
  }

  public static bool b2ShapeCast(b2ShapeCastOutput output, b2ShapeCastInput input) {
    bool ret = Box2dPINVOKE.b2ShapeCast(b2ShapeCastOutput.getCPtr(output), b2ShapeCastInput.getCPtr(input));
    return ret;
  }

  public static readonly double b2_pi = Box2dPINVOKE.b2_pi_get();
  public static readonly int b2_maxManifoldPoints = Box2dPINVOKE.b2_maxManifoldPoints_get();
  public static readonly int b2_maxPolygonVertices = Box2dPINVOKE.b2_maxPolygonVertices_get();
  public static readonly double b2_aabbExtension = Box2dPINVOKE.b2_aabbExtension_get();
  public static readonly double b2_aabbMultiplier = Box2dPINVOKE.b2_aabbMultiplier_get();
  public static readonly double b2_linearSlop = Box2dPINVOKE.b2_linearSlop_get();
  public static readonly double b2_angularSlop = Box2dPINVOKE.b2_angularSlop_get();
  public static readonly double b2_polygonRadius = Box2dPINVOKE.b2_polygonRadius_get();
  public static readonly int b2_maxSubSteps = Box2dPINVOKE.b2_maxSubSteps_get();
  public static readonly int b2_maxTOIContacts = Box2dPINVOKE.b2_maxTOIContacts_get();
  public static readonly double b2_velocityThreshold = Box2dPINVOKE.b2_velocityThreshold_get();
  public static readonly double b2_maxLinearCorrection = Box2dPINVOKE.b2_maxLinearCorrection_get();
  public static readonly double b2_maxAngularCorrection = Box2dPINVOKE.b2_maxAngularCorrection_get();
  public static readonly double b2_maxTranslation = Box2dPINVOKE.b2_maxTranslation_get();
  public static readonly double b2_maxTranslationSquared = Box2dPINVOKE.b2_maxTranslationSquared_get();
  public static readonly double b2_maxRotation = Box2dPINVOKE.b2_maxRotation_get();
  public static readonly double b2_maxRotationSquared = Box2dPINVOKE.b2_maxRotationSquared_get();
  public static readonly double b2_baumgarte = Box2dPINVOKE.b2_baumgarte_get();
  public static readonly double b2_toiBaumgarte = Box2dPINVOKE.b2_toiBaumgarte_get();
  public static readonly double b2_timeToSleep = Box2dPINVOKE.b2_timeToSleep_get();
  public static readonly double b2_linearSleepTolerance = Box2dPINVOKE.b2_linearSleepTolerance_get();
  public static readonly double b2_angularSleepTolerance = Box2dPINVOKE.b2_angularSleepTolerance_get();
  public static readonly int b2_nullNode = Box2dPINVOKE.b2_nullNode_get();
}

}
