//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace EliteQuant {

public class CalibratedModel : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CalibratedModel(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CalibratedModel obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CalibratedModel() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_CalibratedModel(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_CalibratedModel __deref__() {
    global::System.IntPtr cPtr = NQuantLibcPINVOKE.CalibratedModel___deref__(swigCPtr);
    SWIGTYPE_p_CalibratedModel ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CalibratedModel(cPtr, false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isNull() {
    bool ret = NQuantLibcPINVOKE.CalibratedModel_isNull(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Observable asObservable() {
    Observable ret = new Observable(NQuantLibcPINVOKE.CalibratedModel_asObservable(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CalibratedModel() : this(NQuantLibcPINVOKE.new_CalibratedModel(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public QlArray parameters() {
    QlArray ret = new QlArray(NQuantLibcPINVOKE.CalibratedModel_parameters(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void calibrate(CalibrationHelperVector arg0, OptimizationMethod arg1, EndCriteria arg2, Constraint constraint, DoubleVector weights) {
    NQuantLibcPINVOKE.CalibratedModel_calibrate__SWIG_0(swigCPtr, CalibrationHelperVector.getCPtr(arg0), OptimizationMethod.getCPtr(arg1), EndCriteria.getCPtr(arg2), Constraint.getCPtr(constraint), DoubleVector.getCPtr(weights));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void calibrate(CalibrationHelperVector arg0, OptimizationMethod arg1, EndCriteria arg2, Constraint constraint) {
    NQuantLibcPINVOKE.CalibratedModel_calibrate__SWIG_1(swigCPtr, CalibrationHelperVector.getCPtr(arg0), OptimizationMethod.getCPtr(arg1), EndCriteria.getCPtr(arg2), Constraint.getCPtr(constraint));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void calibrate(CalibrationHelperVector arg0, OptimizationMethod arg1, EndCriteria arg2) {
    NQuantLibcPINVOKE.CalibratedModel_calibrate__SWIG_2(swigCPtr, CalibrationHelperVector.getCPtr(arg0), OptimizationMethod.getCPtr(arg1), EndCriteria.getCPtr(arg2));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
