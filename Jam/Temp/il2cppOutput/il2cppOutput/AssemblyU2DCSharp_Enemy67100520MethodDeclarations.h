#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// Enemy
struct Enemy_t67100520;
// UnityEngine.Collider2D
struct Collider2D_t1890038195;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UnityEngine_Collider2D1890038195.h"

// System.Void Enemy::.ctor()
extern "C"  void Enemy__ctor_m1781972739 (Enemy_t67100520 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Enemy::Start()
extern "C"  void Enemy_Start_m729110531 (Enemy_t67100520 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Enemy::Update()
extern "C"  void Enemy_Update_m1133442154 (Enemy_t67100520 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Enemy::OnTriggerEnter2D(UnityEngine.Collider2D)
extern "C"  void Enemy_OnTriggerEnter2D_m490835157 (Enemy_t67100520 * __this, Collider2D_t1890038195 * ___col, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Enemy::TakeDamage(System.Int32)
extern "C"  void Enemy_TakeDamage_m92963336 (Enemy_t67100520 * __this, int32_t ___damage, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Enemy::Die()
extern "C"  void Enemy_Die_m3061436577 (Enemy_t67100520 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
