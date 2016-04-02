#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Rigidbody2D
struct Rigidbody2D_t3632243084;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Enemy
struct  Enemy_t67100520  : public MonoBehaviour_t3012272455
{
public:
	// System.Single Enemy::health
	float ___health_2;
	// System.Boolean Enemy::dead
	bool ___dead_3;
	// UnityEngine.Rigidbody2D Enemy::body
	Rigidbody2D_t3632243084 * ___body_4;
	// System.Single Enemy::speed
	float ___speed_5;

public:
	inline static int32_t get_offset_of_health_2() { return static_cast<int32_t>(offsetof(Enemy_t67100520, ___health_2)); }
	inline float get_health_2() const { return ___health_2; }
	inline float* get_address_of_health_2() { return &___health_2; }
	inline void set_health_2(float value)
	{
		___health_2 = value;
	}

	inline static int32_t get_offset_of_dead_3() { return static_cast<int32_t>(offsetof(Enemy_t67100520, ___dead_3)); }
	inline bool get_dead_3() const { return ___dead_3; }
	inline bool* get_address_of_dead_3() { return &___dead_3; }
	inline void set_dead_3(bool value)
	{
		___dead_3 = value;
	}

	inline static int32_t get_offset_of_body_4() { return static_cast<int32_t>(offsetof(Enemy_t67100520, ___body_4)); }
	inline Rigidbody2D_t3632243084 * get_body_4() const { return ___body_4; }
	inline Rigidbody2D_t3632243084 ** get_address_of_body_4() { return &___body_4; }
	inline void set_body_4(Rigidbody2D_t3632243084 * value)
	{
		___body_4 = value;
		Il2CppCodeGenWriteBarrier(&___body_4, value);
	}

	inline static int32_t get_offset_of_speed_5() { return static_cast<int32_t>(offsetof(Enemy_t67100520, ___speed_5)); }
	inline float get_speed_5() const { return ___speed_5; }
	inline float* get_address_of_speed_5() { return &___speed_5; }
	inline void set_speed_5(float value)
	{
		___speed_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
