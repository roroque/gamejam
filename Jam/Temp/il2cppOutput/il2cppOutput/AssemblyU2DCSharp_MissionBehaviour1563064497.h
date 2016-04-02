#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t4012695102;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// MissionBehaviour
struct  MissionBehaviour_t1563064497  : public MonoBehaviour_t3012272455
{
public:
	// System.Single MissionBehaviour::missionDistance
	float ___missionDistance_2;
	// UnityEngine.GameObject MissionBehaviour::canvasDeath
	GameObject_t4012695102 * ___canvasDeath_3;
	// UnityEngine.GameObject MissionBehaviour::canvasWin
	GameObject_t4012695102 * ___canvasWin_4;
	// System.Single MissionBehaviour::currentDistance
	float ___currentDistance_5;
	// System.Single MissionBehaviour::speed
	float ___speed_6;
	// System.Boolean MissionBehaviour::stopCounting
	bool ___stopCounting_7;

public:
	inline static int32_t get_offset_of_missionDistance_2() { return static_cast<int32_t>(offsetof(MissionBehaviour_t1563064497, ___missionDistance_2)); }
	inline float get_missionDistance_2() const { return ___missionDistance_2; }
	inline float* get_address_of_missionDistance_2() { return &___missionDistance_2; }
	inline void set_missionDistance_2(float value)
	{
		___missionDistance_2 = value;
	}

	inline static int32_t get_offset_of_canvasDeath_3() { return static_cast<int32_t>(offsetof(MissionBehaviour_t1563064497, ___canvasDeath_3)); }
	inline GameObject_t4012695102 * get_canvasDeath_3() const { return ___canvasDeath_3; }
	inline GameObject_t4012695102 ** get_address_of_canvasDeath_3() { return &___canvasDeath_3; }
	inline void set_canvasDeath_3(GameObject_t4012695102 * value)
	{
		___canvasDeath_3 = value;
		Il2CppCodeGenWriteBarrier(&___canvasDeath_3, value);
	}

	inline static int32_t get_offset_of_canvasWin_4() { return static_cast<int32_t>(offsetof(MissionBehaviour_t1563064497, ___canvasWin_4)); }
	inline GameObject_t4012695102 * get_canvasWin_4() const { return ___canvasWin_4; }
	inline GameObject_t4012695102 ** get_address_of_canvasWin_4() { return &___canvasWin_4; }
	inline void set_canvasWin_4(GameObject_t4012695102 * value)
	{
		___canvasWin_4 = value;
		Il2CppCodeGenWriteBarrier(&___canvasWin_4, value);
	}

	inline static int32_t get_offset_of_currentDistance_5() { return static_cast<int32_t>(offsetof(MissionBehaviour_t1563064497, ___currentDistance_5)); }
	inline float get_currentDistance_5() const { return ___currentDistance_5; }
	inline float* get_address_of_currentDistance_5() { return &___currentDistance_5; }
	inline void set_currentDistance_5(float value)
	{
		___currentDistance_5 = value;
	}

	inline static int32_t get_offset_of_speed_6() { return static_cast<int32_t>(offsetof(MissionBehaviour_t1563064497, ___speed_6)); }
	inline float get_speed_6() const { return ___speed_6; }
	inline float* get_address_of_speed_6() { return &___speed_6; }
	inline void set_speed_6(float value)
	{
		___speed_6 = value;
	}

	inline static int32_t get_offset_of_stopCounting_7() { return static_cast<int32_t>(offsetof(MissionBehaviour_t1563064497, ___stopCounting_7)); }
	inline bool get_stopCounting_7() const { return ___stopCounting_7; }
	inline bool* get_address_of_stopCounting_7() { return &___stopCounting_7; }
	inline void set_stopCounting_7(bool value)
	{
		___stopCounting_7 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
