#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject[]
struct GameObjectU5BU5D_t3499186955;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// spawner
struct  spawner_t2283408744  : public MonoBehaviour_t3012272455
{
public:
	// System.Single spawner::timer
	float ___timer_2;
	// System.Single spawner::counter
	float ___counter_3;
	// System.Single spawner::minTime
	float ___minTime_4;
	// System.Single spawner::maxTime
	float ___maxTime_5;
	// System.Single spawner::nextTime
	float ___nextTime_6;
	// UnityEngine.GameObject[] spawner::stuff
	GameObjectU5BU5D_t3499186955* ___stuff_7;
	// UnityEngine.GameObject[] spawner::enemies
	GameObjectU5BU5D_t3499186955* ___enemies_8;

public:
	inline static int32_t get_offset_of_timer_2() { return static_cast<int32_t>(offsetof(spawner_t2283408744, ___timer_2)); }
	inline float get_timer_2() const { return ___timer_2; }
	inline float* get_address_of_timer_2() { return &___timer_2; }
	inline void set_timer_2(float value)
	{
		___timer_2 = value;
	}

	inline static int32_t get_offset_of_counter_3() { return static_cast<int32_t>(offsetof(spawner_t2283408744, ___counter_3)); }
	inline float get_counter_3() const { return ___counter_3; }
	inline float* get_address_of_counter_3() { return &___counter_3; }
	inline void set_counter_3(float value)
	{
		___counter_3 = value;
	}

	inline static int32_t get_offset_of_minTime_4() { return static_cast<int32_t>(offsetof(spawner_t2283408744, ___minTime_4)); }
	inline float get_minTime_4() const { return ___minTime_4; }
	inline float* get_address_of_minTime_4() { return &___minTime_4; }
	inline void set_minTime_4(float value)
	{
		___minTime_4 = value;
	}

	inline static int32_t get_offset_of_maxTime_5() { return static_cast<int32_t>(offsetof(spawner_t2283408744, ___maxTime_5)); }
	inline float get_maxTime_5() const { return ___maxTime_5; }
	inline float* get_address_of_maxTime_5() { return &___maxTime_5; }
	inline void set_maxTime_5(float value)
	{
		___maxTime_5 = value;
	}

	inline static int32_t get_offset_of_nextTime_6() { return static_cast<int32_t>(offsetof(spawner_t2283408744, ___nextTime_6)); }
	inline float get_nextTime_6() const { return ___nextTime_6; }
	inline float* get_address_of_nextTime_6() { return &___nextTime_6; }
	inline void set_nextTime_6(float value)
	{
		___nextTime_6 = value;
	}

	inline static int32_t get_offset_of_stuff_7() { return static_cast<int32_t>(offsetof(spawner_t2283408744, ___stuff_7)); }
	inline GameObjectU5BU5D_t3499186955* get_stuff_7() const { return ___stuff_7; }
	inline GameObjectU5BU5D_t3499186955** get_address_of_stuff_7() { return &___stuff_7; }
	inline void set_stuff_7(GameObjectU5BU5D_t3499186955* value)
	{
		___stuff_7 = value;
		Il2CppCodeGenWriteBarrier(&___stuff_7, value);
	}

	inline static int32_t get_offset_of_enemies_8() { return static_cast<int32_t>(offsetof(spawner_t2283408744, ___enemies_8)); }
	inline GameObjectU5BU5D_t3499186955* get_enemies_8() const { return ___enemies_8; }
	inline GameObjectU5BU5D_t3499186955** get_address_of_enemies_8() { return &___enemies_8; }
	inline void set_enemies_8(GameObjectU5BU5D_t3499186955* value)
	{
		___enemies_8 = value;
		Il2CppCodeGenWriteBarrier(&___enemies_8, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
