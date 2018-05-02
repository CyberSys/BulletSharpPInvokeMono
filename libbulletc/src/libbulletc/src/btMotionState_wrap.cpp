#include <new>
#include <LinearMath/btMotionState.h>

#include "conversion.h"
#include "btMotionState_wrap.h"

btMotionStateWrapper::btMotionStateWrapper(p_btMotionState_getWorldTransform getWorldTransformCallback,
	p_btMotionState_setWorldTransform setWorldTransformCallback, void* managedMotionStatePtr)
{
	managedMotionState = managedMotionStatePtr;
	_getWorldTransformCallback = getWorldTransformCallback;
	_setWorldTransformCallback = setWorldTransformCallback;
}

void btMotionStateWrapper::getWorldTransform(btTransform& worldTrans) const
{
	BTTRANSFORM_DEF(worldTrans);
	_getWorldTransformCallback(managedMotionState, &BTTRANSFORM_USE_REF(worldTrans));
	BTTRANSFORM_DEF_OUT_REF(worldTrans);
}

void btMotionStateWrapper::setWorldTransform(const btTransform& worldTrans)
{
	BTTRANSFORM_IN_REF(worldTrans);
	_setWorldTransformCallback(managedMotionState, &BTTRANSFORM_USE_REF(worldTrans));
}


btMotionStateWrapper* btMotionStateWrapper_new(p_btMotionState_getWorldTransform getWorldTransformCallback,
	p_btMotionState_setWorldTransform setWorldTransformCallback, void* managedMotionStatePtr)
{
	return ALIGNED_NEW(btMotionStateWrapper)(getWorldTransformCallback, setWorldTransformCallback, managedMotionStatePtr);
}


void btMotionState_getWorldTransform(btMotionState* obj, btTransform* worldTrans)
{
	BTTRANSFORM_IN(worldTrans);
	obj->getWorldTransform(BTTRANSFORM_USE(worldTrans));
	BTTRANSFORM_DEF_OUT(worldTrans);
}

void btMotionState_setWorldTransform(btMotionState* obj, const btTransform* worldTrans)
{
	BTTRANSFORM_IN(worldTrans);
	obj->setWorldTransform(BTTRANSFORM_USE(worldTrans));
}

void btMotionState_delete(btMotionState* obj)
{
	ALIGNED_FREE(obj);
}
