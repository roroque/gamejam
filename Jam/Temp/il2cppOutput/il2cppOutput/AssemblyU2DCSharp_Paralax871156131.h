#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// Paralax
struct Paralax_t871156131;
// UnityEngine.Texture[]
struct TextureU5BU5D_t3618347161;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Paralax
struct  Paralax_t871156131  : public MonoBehaviour_t3012272455
{
public:
	// System.Single Paralax::speed
	float ___speed_2;
	// Paralax Paralax::current
	Paralax_t871156131 * ___current_3;
	// UnityEngine.Texture[] Paralax::textures
	TextureU5BU5D_t3618347161* ___textures_4;
	// System.Single Paralax::pos
	float ___pos_5;

public:
	inline static int32_t get_offset_of_speed_2() { return static_cast<int32_t>(offsetof(Paralax_t871156131, ___speed_2)); }
	inline float get_speed_2() const { return ___speed_2; }
	inline float* get_address_of_speed_2() { return &___speed_2; }
	inline void set_speed_2(float value)
	{
		___speed_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Paralax_t871156131, ___current_3)); }
	inline Paralax_t871156131 * get_current_3() const { return ___current_3; }
	inline Paralax_t871156131 ** get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(Paralax_t871156131 * value)
	{
		___current_3 = value;
		Il2CppCodeGenWriteBarrier(&___current_3, value);
	}

	inline static int32_t get_offset_of_textures_4() { return static_cast<int32_t>(offsetof(Paralax_t871156131, ___textures_4)); }
	inline TextureU5BU5D_t3618347161* get_textures_4() const { return ___textures_4; }
	inline TextureU5BU5D_t3618347161** get_address_of_textures_4() { return &___textures_4; }
	inline void set_textures_4(TextureU5BU5D_t3618347161* value)
	{
		___textures_4 = value;
		Il2CppCodeGenWriteBarrier(&___textures_4, value);
	}

	inline static int32_t get_offset_of_pos_5() { return static_cast<int32_t>(offsetof(Paralax_t871156131, ___pos_5)); }
	inline float get_pos_5() const { return ___pos_5; }
	inline float* get_address_of_pos_5() { return &___pos_5; }
	inline void set_pos_5(float value)
	{
		___pos_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
