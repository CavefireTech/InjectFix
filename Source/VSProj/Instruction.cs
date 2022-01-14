/*
 * Tencent is pleased to support the open source community by making InjectFix available.
 * Copyright (C) 2019 THL A29 Limited, a Tencent company.  All rights reserved.
 * InjectFix is licensed under the MIT License, except for the third-party components listed in the file 'LICENSE' which may be subject to their corresponding license terms. 
 * This file is subject to the terms and conditions defined in file 'LICENSE', which is part of this source code package.
 */

namespace IFix.Core
{
    public enum Code
    {
        Ldftn,
        Ldelem_I2,
        Break,
        Sub_Ovf_Un,
        Conv_Ovf_I_Un,
        Ldind_I8,
        Ldelem_Any,
        Cpblk,
        Conv_Ovf_U4_Un,
        Ldsflda,
        Conv_I2,
        Isinst,
        Refanyval,
        Ldarg,
        Stobj,
        Newobj,
        Rem,
        Ldind_I,
        Conv_Ovf_I2_Un,
        Ldelem_I8,
        Add_Ovf,
        Shl,
        Neg,
        Stelem_I,
        Stelem_Ref,
        Stelem_I2,
        Conv_Ovf_U_Un,
        Unbox,
        Callvirt,
        Conv_Ovf_U8_Un,
        Dup,
        Mul_Ovf_Un,
        Conv_I1,
        Ldvirtftn2,
        Stind_I1,

        //Pseudo instruction
        StackSpace,
        Stind_I2,
        Castclass,
        Conv_U8,
        Tail,
        Conv_Ovf_U1,
        Stelem_I8,
        Conv_U2,
        Localloc,
        Conv_R8,
        Newanon,
        Beq,
        Ldflda,
        Unbox_Any,
        Volatile,
        Ldind_I4,
        Sub,
        Ldind_R8,
        Conv_Ovf_U2,
        Ldc_R8,
        Ldelema,
        Ldc_I8,
        Ldelem_R8,
        Ldelem_R4,
        Conv_Ovf_U1_Un,
        Cgt_Un,
        Ldelem_U1,
        Bgt,
        Throw,
        Constrained,
        Ckfinite,
        Ble_Un,
        Nop,
        Conv_Ovf_I2,
        Conv_U,
        Mul_Ovf,
        Box,
        Call,
        Div,
        Ldelem_I1,
        Unaligned,
        Ldc_R4,
        Ldind_I2,
        Brfalse,
        Div_Un,
        Stelem_R8,
        Ldtype, // custom
        Br,
        Ldloca,
        Stind_I8,
        Conv_Ovf_U8,
        Ldind_U4,
        Stind_I,
        Ldvirtftn,
        Callvirtvirt,
        Brtrue,
        Pop,
        Conv_Ovf_U2_Un,
        Arglist,
        Readonly,
        Stelem_I4,
        Xor,
        Conv_I,
        Jmp,
        Shr,
        Stind_R8,
        Blt,
        Clt,
        Stloc,
        Sizeof,
        Stelem_R4,
        Ret,
        Bgt_Un,
        Ldfld,
        No,
        Conv_Ovf_I8,
        Stind_I4,
        Ldelem_U4,
        Ldtoken,
        Endfinally,
        And,
        Blt_Un,
        Conv_Ovf_I1,
        Mkrefany,
        Initblk,
        Stfld,
        Ldelem_Ref,
        Switch,
        Conv_U1,
        Ldind_U2,
        Conv_Ovf_I4_Un,
        Sub_Ovf,
        Add,
        Ldarga,
        Stind_R4,
        Conv_Ovf_U4,
        Refanytype,
        Stelem_I1,
        Endfilter,
        Stelem_Any,
        Conv_Ovf_I,
        Stind_Ref,
        Conv_R4,
        //Calli,
        Starg,
        Mul,
        Bne_Un,
        Not,
        Ldelem_I4,
        Initobj,
        Ldstr,
        Add_Ovf_Un,
        Bge,
        Rem_Un,
        Conv_Ovf_I4,
        Ldelem_U2,
        Conv_Ovf_I1_Un,
        Or,
        Ldc_I4,
        Ble,
        Conv_U4,
        Ldind_R4,
        CallExtern,
        Ldsfld,
        Ldind_I1,
        Shr_Un,
        Stsfld,
        Cpobj,
        Ldind_Ref,
        Conv_R_Un,
        Ldind_U1,
        Clt_Un,
        Bge_Un,
        Conv_I4,
        Ldlen,
        Conv_I8,
        Ldloc,
        Ldelem_I,
        Conv_Ovf_U,
        Newarr,
        Cgt,
        Ldobj,
        Conv_Ovf_I8_Un,
        Ldnull,
        Leave,
        Rethrow,
        Ceq,
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Instruction
    {
        /// <summary>
        /// 指令MAGIC
        /// </summary>
        public const ulong INSTRUCTION_FORMAT_MAGIC = 6476347187315540811;

        /// <summary>
        /// 当前指令
        /// </summary>
        public Code Code;

        /// <summary>
        /// 操作数
        /// </summary>
        public int Operand;
    }

    public enum ExceptionHandlerType
    {
        Catch = 0,
        Filter = 1,
        Finally = 2,
        Fault = 4
    }

    public sealed class ExceptionHandler
    {
        public System.Type CatchType;
        public int CatchTypeId;
        public int HandlerEnd;
        public int HandlerStart;
        public ExceptionHandlerType HandlerType;
        public int TryEnd;
        public int TryStart;
    }
}