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
        Ldelem_U4,
        Sizeof,
        Volatile,
        Conv_U8,
        Ble,
        Stelem_Any,
        Ldelem_Ref,
        Unbox,
        Conv_Ovf_U8_Un,
        Stelem_Ref,
        Ldsfld,
        Mul_Ovf_Un,
        Ckfinite,
        Conv_Ovf_U_Un,
        Starg,
        Bge,
        Blt_Un,
        Conv_I8,
        Ldvirtftn2,
        Br,
        Bge_Un,
        Beq,
        Ldnull,
        Stelem_I4,
        Ldelem_I,
        Ldind_I2,
        Stsfld,
        Ldind_R8,
        Sub,
        Rem_Un,
        Ldc_I8,
        Ldelem_Any,
        CallExtern,
        Endfinally,
        Ldc_R8,
        Ldelem_U2,
        Ldtype, // custom
        Cgt_Un,
        Div_Un,
        Conv_Ovf_I1,
        Conv_I,
        Conv_Ovf_I8_Un,
        Conv_Ovf_I2_Un,
        Ldind_U4,
        Mul,
        And,
        Nop,
        Ldelem_I4,
        Ldind_R4,
        Conv_Ovf_U,
        Ldfld,
        Mul_Ovf,
        Readonly,
        Conv_U1,
        Conv_Ovf_I4_Un,
        Dup,
        Ldelem_I1,
        Conv_U,
        Div,
        Ldind_U1,
        Brtrue,
        Ldind_I,
        Cpblk,
        Conv_U2,
        Endfilter,
        Brfalse,
        Ldc_I4,
        Break,
        Stind_R8,
        Arglist,
        Ldelema,
        No,
        Ldind_Ref,
        Ldobj,
        Conv_Ovf_U4,
        Conv_Ovf_I8,
        Ldelem_I8,
        Unaligned,
        Ldarg,
        Stelem_I1,
        Unbox_Any,
        Conv_I1,
        Ldind_U2,
        Stind_Ref,
        Stind_R4,
        Conv_Ovf_U2,
        //Calli,
        Conv_Ovf_I1_Un,
        Conv_R_Un,
        Ldc_R4,
        Conv_Ovf_I,
        Add_Ovf_Un,
        Stfld,
        Sub_Ovf_Un,
        Constrained,
        Stind_I2,
        Bgt_Un,
        Ldelem_U1,
        Conv_R4,
        Conv_R8,
        Ldflda,
        Stelem_I8,
        Neg,
        Ldind_I1,
        Ble_Un,
        Ldelem_R8,
        Shr_Un,
        Refanyval,
        Mkrefany,
        Conv_Ovf_I2,
        Ldind_I8,
        Conv_I2,
        Conv_Ovf_U1_Un,
        Newarr,
        Conv_Ovf_U4_Un,
        Stind_I,
        Ret,
        Clt,

        //Pseudo instruction
        StackSpace,
        Add,
        Ldloca,
        Stloc,
        Ldftn,
        Stind_I8,
        Conv_Ovf_U8,
        Switch,
        Tail,
        Blt,
        Ldelem_I2,
        Leave,
        Conv_Ovf_I_Un,
        Conv_Ovf_I4,
        Rem,
        Stelem_I2,
        Ldloc,
        Stind_I4,
        Ldelem_R4,
        Throw,
        Newobj,
        Stind_I1,
        Conv_I4,
        Ldind_I4,
        Box,
        Not,
        Callvirtvirt,
        Stelem_R8,
        Pop,
        Castclass,
        Conv_U4,
        Callvirt,
        Refanytype,
        Jmp,
        Stobj,
        Initobj,
        Conv_Ovf_U2_Un,
        Ceq,
        Conv_Ovf_U1,
        Cpobj,
        Sub_Ovf,
        Ldtoken,
        Xor,
        Call,
        Ldarga,
        Rethrow,
        Localloc,
        Add_Ovf,
        Ldstr,
        Clt_Un,
        Isinst,
        Shr,
        Ldsflda,
        Newanon,
        Bgt,
        Or,
        Ldlen,
        Stelem_R4,
        Ldvirtftn,
        Shl,
        Cgt,
        Stelem_I,
        Bne_Un,
        Initblk,
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Instruction
    {
        /// <summary>
        /// 指令MAGIC
        /// </summary>
        public const ulong INSTRUCTION_FORMAT_MAGIC = 7158129905953336780;

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