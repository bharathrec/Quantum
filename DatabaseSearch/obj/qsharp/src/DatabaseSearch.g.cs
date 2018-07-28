#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Samples.DatabaseSearch", "DatabaseOracle (markedQubit : Qubit, databaseRegister : Qubit[]) : ()", new string[] { "Adjoint" }, "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs", 3275L, 70L, 82L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Samples.DatabaseSearch", "UniformSuperpositionOracle (databaseRegister : Qubit[]) : ()", new string[] { "Adjoint" }, "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs", 4626L, 107L, 74L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Samples.DatabaseSearch", "StatePreparationOracle (markedQubit : Qubit, databaseRegister : Qubit[]) : ()", new string[] { "Adjoint" }, "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs", 6238L, 145L, 90L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Samples.DatabaseSearch", "ReflectMarked (markedQubit : Qubit) : ()", new string[] { }, "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs", 7046L, 169L, 54L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Samples.DatabaseSearch", "ReflectZero (databaseRegister : Qubit[]) : ()", new string[] { }, "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs", 7427L, 182L, 60L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Samples.DatabaseSearch", "ReflectStart (markedQubit : Qubit, databaseRegister : Qubit[]) : ()", new string[] { }, "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs", 8158L, 203L, 81L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Samples.DatabaseSearch", "QuantumSearch (nIterations : Int, markedQubit : Qubit, databaseRegister : Qubit[]) : ()", new string[] { }, "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs", 9652L, 237L, 101L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Samples.DatabaseSearch", "ApplyQuantumSearch (nIterations : Int, nDatabaseQubits : Int) : (Result, Result[])", new string[] { }, "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs", 10835L, 267L, 97L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Samples.DatabaseSearch", "StatePreparationOracleTest () : ()", new string[] { }, "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs", 12762L, 316L, 47L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Samples.DatabaseSearch", "GroverHardCodedTest () : ()", new string[] { }, "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs", 14424L, 356L, 42L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Samples.DatabaseSearch", "DatabaseOracleFromInts (markedElements : Int[], markedQubit : Qubit, databaseRegister : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs", 18505L, 441L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Samples.DatabaseSearch", "GroverStatePrepOracleImpl (markedElements : Int[], idxMarkedQubit : Int, startQubits : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs", 20105L, 480L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Samples.DatabaseSearch", "ApplyGroverSearch (markedElements : Int[], nIterations : Int, nDatabaseQubits : Int) : (Result, Int)", new string[] { }, "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs", 22774L, 557L, 114L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Samples.DatabaseSearch", "GroverStatePrepOracle (markedElements : Int[]) : Microsoft.Quantum.Canon.StateOracle", new string[] { }, "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs", 20963L, 510L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Samples.DatabaseSearch", "GroverSearch (markedElements : Int[], nIterations : Int, idxMarkedQubit : Int) : (Qubit[] => () : Adjoint, Controlled)", new string[] { }, "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs", 21807L, 535L, 14L)]
#line hidden
namespace Microsoft.Quantum.Samples.DatabaseSearch
{
    public class DatabaseOracle : Adjointable<(Qubit,QArray<Qubit>)>, ICallable
    {
        public DatabaseOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "DatabaseOracle";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.DatabaseOracle";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (markedQubit,databaseRegister) = __in;
            // The Controlled functor applies its operation conditioned on the
            // first input being in the |11…1〉 state, which is precisely
            // what we need for this example.
#line 75 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((databaseRegister, markedQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (markedQubit,databaseRegister) = __in;
            // The Controlled functor applies its operation conditioned on the
            // first input being in the |11…1〉 state, which is precisely
            // what we need for this example.
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((databaseRegister, markedQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<DatabaseOracle, (Qubit,QArray<Qubit>), QVoid>((markedQubit, databaseRegister));
        }
    }

    public class UniformSuperpositionOracle : Adjointable<QArray<Qubit>>, ICallable
    {
        public UniformSuperpositionOracle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "UniformSuperpositionOracle";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.UniformSuperpositionOracle";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var databaseRegister = __in;
#line 109 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var nQubits = databaseRegister.Count;
#line 110 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            foreach (var idxQubit in new Range(0L, (nQubits - 1L)))
            {
#line 111 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                MicrosoftQuantumPrimitiveH.Apply(databaseRegister[idxQubit]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in) =>
        {
            var databaseRegister = __in;
#line 109 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var nQubits = databaseRegister.Count;
            foreach (var idxQubit in new Range((0L - ((((nQubits - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                MicrosoftQuantumPrimitiveH.Adjoint.Apply(databaseRegister[idxQubit]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<UniformSuperpositionOracle, QArray<Qubit>, QVoid>(databaseRegister);
        }
    }

    public class StatePreparationOracle : Adjointable<(Qubit,QArray<Qubit>)>, ICallable
    {
        public StatePreparationOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "StatePreparationOracle";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.StatePreparationOracle";
        protected IAdjointable<(Qubit,QArray<Qubit>)> DatabaseOracle
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> UniformSuperpositionOracle
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (markedQubit,databaseRegister) = __in;
#line 147 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            UniformSuperpositionOracle.Apply(databaseRegister);
#line 148 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            DatabaseOracle.Apply((markedQubit, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (markedQubit,databaseRegister) = __in;
            DatabaseOracle.Adjoint.Apply((markedQubit, databaseRegister));
            UniformSuperpositionOracle.Adjoint.Apply(databaseRegister);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DatabaseOracle = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Samples.DatabaseSearch.DatabaseOracle));
            this.UniformSuperpositionOracle = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(Microsoft.Quantum.Samples.DatabaseSearch.UniformSuperpositionOracle));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<StatePreparationOracle, (Qubit,QArray<Qubit>), QVoid>((markedQubit, databaseRegister));
        }
    }

    public class ReflectMarked : Operation<Qubit, QVoid>, ICallable
    {
        public ReflectMarked(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectMarked";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ReflectMarked";
        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveR1
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in) =>
        {
            var markedQubit = __in;
            // Marked elements always have the marked qubit in the state |1〉.
#line 172 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            MicrosoftQuantumPrimitiveR1.Apply((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance), markedQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumPrimitiveR1 = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit)
        {
            return __m__.Run<ReflectMarked, Qubit, QVoid>(markedQubit);
        }
    }

    public class ReflectZero : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public ReflectZero(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectZero";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ReflectZero";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var databaseRegister = __in;
#line 184 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var nQubits = databaseRegister.Count;
#line 185 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            foreach (var idxQubit in new Range(0L, (nQubits - 1L)))
            {
#line 186 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                MicrosoftQuantumPrimitiveX.Apply(databaseRegister[idxQubit]);
            }

#line 188 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            MicrosoftQuantumPrimitiveZ.Controlled.Apply((databaseRegister?.Slice(new Range(1L, (nQubits - 1L))), databaseRegister[0L]));
#line 189 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            foreach (var idxQubit in new Range(0L, (nQubits - 1L)))
            {
#line 190 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                MicrosoftQuantumPrimitiveX.Apply(databaseRegister[idxQubit]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<ReflectZero, QArray<Qubit>, QVoid>(databaseRegister);
        }
    }

    public class ReflectStart : Operation<(Qubit,QArray<Qubit>), QVoid>, ICallable
    {
        public ReflectStart(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ReflectStart";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ReflectStart";
        protected ICallable<QArray<Qubit>, QVoid> ReflectZero
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,QArray<Qubit>)> StatePreparationOracle
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (markedQubit,databaseRegister) = __in;
#line 205 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            StatePreparationOracle.Adjoint.Apply((markedQubit, databaseRegister));
#line 206 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            ReflectZero.Apply((new QArray<Qubit>()
            {markedQubit} + databaseRegister));
#line 207 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            StatePreparationOracle.Apply((markedQubit, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ReflectZero = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Samples.DatabaseSearch.ReflectZero));
            this.StatePreparationOracle = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Samples.DatabaseSearch.StatePreparationOracle));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<ReflectStart, (Qubit,QArray<Qubit>), QVoid>((markedQubit, databaseRegister));
        }
    }

    public class QuantumSearch : Operation<(Int64,Qubit,QArray<Qubit>), QVoid>, ICallable
    {
        public QuantumSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Int64,Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "QuantumSearch";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.QuantumSearch";
        protected ICallable<Qubit, QVoid> ReflectMarked
        {
            get;
            set;
        }

        protected ICallable<(Qubit,QArray<Qubit>), QVoid> ReflectStart
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,QArray<Qubit>)> StatePreparationOracle
        {
            get;
            set;
        }

        public override Func<(Int64,Qubit,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (nIterations,markedQubit,databaseRegister) = __in;
#line 239 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            StatePreparationOracle.Apply((markedQubit, databaseRegister));
            // Loop over Grover iterates.
#line 241 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            foreach (var idx in new Range(0L, (nIterations - 1L)))
            {
#line 242 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                ReflectMarked.Apply(markedQubit);
#line 243 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                ReflectStart.Apply((markedQubit, databaseRegister));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ReflectMarked = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Samples.DatabaseSearch.ReflectMarked));
            this.ReflectStart = this.Factory.Get<ICallable<(Qubit,QArray<Qubit>), QVoid>>(typeof(Microsoft.Quantum.Samples.DatabaseSearch.ReflectStart));
            this.StatePreparationOracle = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Samples.DatabaseSearch.StatePreparationOracle));
        }

        public override IApplyData __dataIn((Int64,Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 nIterations, Qubit markedQubit, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<QuantumSearch, (Int64,Qubit,QArray<Qubit>), QVoid>((nIterations, markedQubit, databaseRegister));
        }
    }

    public class ApplyQuantumSearch : Operation<(Int64,Int64), (Result,QArray<Result>)>, ICallable
    {
        public ApplyQuantumSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Result,QArray<Result>)>, IApplyData
        {
            public Out((Result,QArray<Result>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ApplyQuantumSearch";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ApplyQuantumSearch";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QArray<Result>> MicrosoftQuantumCanonMultiM
        {
            get;
            set;
        }

        protected ICallable<(Int64,Qubit,QArray<Qubit>), QVoid> QuantumSearch
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), (Result,QArray<Result>)> Body => (__in) =>
        {
            var (nIterations,nDatabaseQubits) = __in;
            // Allocate variables to store measurement results.
#line 270 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var resultSuccess = Result.Zero;
#line 271 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var resultElement = new QArray<Result>(nDatabaseQubits);
            // Allocate nDatabaseQubits + 1 qubits. These are all in the |0〉
            // state.
#line 275 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var qubits = Allocate.Apply((nDatabaseQubits + 1L));
            // Define marked qubit to be indexed by 0.
#line 278 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var markedQubit = qubits[0L];
            // Let all other qubits be the database register.
#line 281 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var databaseRegister = qubits?.Slice(new Range(1L, nDatabaseQubits));
            // Implement the quantum search algorithm.
#line 284 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            QuantumSearch.Apply((nIterations, markedQubit, databaseRegister));
            // Measure the marked qubit. On success, this should be One.
#line 287 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            resultSuccess = M.Apply(markedQubit);
            // Measure the state of the database register post-selected on
            // the state of the marked qubit.
#line 291 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            resultElement = MicrosoftQuantumCanonMultiM.Apply(databaseRegister);
            // These reset all qubits to the |0〉 state, which is required 
            // before deallocation.
#line 295 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            if ((resultSuccess == Result.One))
            {
#line 296 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                MicrosoftQuantumPrimitiveX.Apply(markedQubit);
            }

#line 298 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            foreach (var idxResult in new Range(0L, (nDatabaseQubits - 1L)))
            {
#line 299 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                if ((resultElement[idxResult] == Result.One))
                {
#line 300 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                    MicrosoftQuantumPrimitiveX.Apply(databaseRegister[idxResult]);
                }
            }

#line hidden
            Release.Apply(qubits);
            // Returns the measurement results of the algorithm.
#line 306 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            return (resultSuccess, resultElement);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumCanonMultiM = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Microsoft.Quantum.Canon.MultiM));
            this.QuantumSearch = this.Factory.Get<ICallable<(Int64,Qubit,QArray<Qubit>), QVoid>>(typeof(Microsoft.Quantum.Samples.DatabaseSearch.QuantumSearch));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut((Result,QArray<Result>) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,QArray<Result>)> Run(IOperationFactory __m__, Int64 nIterations, Int64 nDatabaseQubits)
        {
            return __m__.Run<ApplyQuantumSearch, (Int64,Int64), (Result,QArray<Result>)>((nIterations, nDatabaseQubits));
        }
    }

    public class StatePreparationOracleTest : Operation<QVoid, QVoid>, ICallable
    {
        public StatePreparationOracleTest(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "StatePreparationOracleTest";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.StatePreparationOracleTest";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)> AssertProb
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,QArray<Qubit>)> StatePreparationOracle
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 319 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            foreach (var nDatabaseQubits in new Range(0L, 5L))
            {
#line 321 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                var qubits = Allocate.Apply((nDatabaseQubits + 1L));
#line 323 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                var markedQubit = qubits[0L];
#line 324 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                var databaseRegister = qubits?.Slice(new Range(1L, nDatabaseQubits));
#line 326 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                StatePreparationOracle.Apply((markedQubit, databaseRegister));
                // This is the success probability as predicted by theory.
                // Note that this is computed only to verify that we have 
                // implemented Grover's algorithm correctly in the 
                // `AssertProb` below.
#line 333 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                var successAmplitude = (1D / MicrosoftQuantumExtensionsMathSqrt.Apply(MicrosoftQuantumExtensionsConvertToDouble.Apply(2L.Pow(nDatabaseQubits))));
#line 334 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                var successProbability = (successAmplitude * successAmplitude);
#line 337 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                AssertProb.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, new QArray<Qubit>()
                {markedQubit}, Result.One, successProbability, "Error: Success probability does not match theory", 1E-10D));
                // This function automatically resets all qubits to |0〉
                // for safe deallocation.
#line 341 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                ResetAll.Apply(qubits);
#line hidden
                Release.Apply(qubits);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.AssertProb = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)>>(typeof(Microsoft.Quantum.Primitive.AssertProb));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
            this.StatePreparationOracle = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Samples.DatabaseSearch.StatePreparationOracle));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<StatePreparationOracleTest, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class GroverHardCodedTest : Operation<QVoid, QVoid>, ICallable
    {
        public GroverHardCodedTest(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GroverHardCodedTest";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.GroverHardCodedTest";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathArcSin
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)> AssertProb
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QArray<Result>> MicrosoftQuantumCanonMultiM
        {
            get;
            set;
        }

        protected ICallable<(Int64,Qubit,QArray<Qubit>), QVoid> QuantumSearch
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSin
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 359 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            foreach (var nDatabaseQubits in new Range(0L, 4L))
            {
#line 360 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                foreach (var nIterations in new Range(0L, 5L))
                {
#line 361 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                    var qubits = Allocate.Apply((nDatabaseQubits + 1L));
#line 362 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                    ResetAll.Apply(qubits);
#line 364 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                    var markedQubit = qubits[0L];
#line 365 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                    var databaseRegister = qubits?.Slice(new Range(1L, nDatabaseQubits));
#line 366 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                    QuantumSearch.Apply((nIterations, markedQubit, databaseRegister));
#line 368 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                    var successAmplitude = MicrosoftQuantumExtensionsMathSin.Apply((MicrosoftQuantumExtensionsConvertToDouble.Apply(((2L * nIterations) + 1L)) * MicrosoftQuantumExtensionsMathArcSin.Apply((1D / MicrosoftQuantumExtensionsMathSqrt.Apply(MicrosoftQuantumExtensionsConvertToDouble.Apply(2L.Pow(nDatabaseQubits)))))));
#line 369 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                    var successProbability = (successAmplitude * successAmplitude);
#line 371 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                    AssertProb.Apply((new QArray<Pauli>()
                    {Pauli.PauliZ}, new QArray<Qubit>()
                    {markedQubit}, Result.One, successProbability, "Error: Success probability does not match theory", 1E-10D));
                    // If this result is One, we have found the marked
                    // element.
#line 375 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                    var result = M.Apply(markedQubit);
#line 376 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                    if ((result == Result.One))
                    {
#line 377 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                        var results = MicrosoftQuantumCanonMultiM.Apply(databaseRegister);
                        // Post-selected on success, verify that that 
                        // database qubits are all |1〉.
#line 381 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                        foreach (var idxResult in new Range(0L, (nDatabaseQubits - 1L)))
                        {
#line 382 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                            if ((results[idxResult] == Result.Zero))
                            {
#line 383 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                                throw new ExecutionFailException("Found state should be 1..1 string.");
                            }
                        }
                    }

#line 388 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                    ResetAll.Apply(qubits);
#line hidden
                    Release.Apply(qubits);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumExtensionsMathArcSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.ArcSin));
            this.AssertProb = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)>>(typeof(Microsoft.Quantum.Primitive.AssertProb));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumCanonMultiM = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Microsoft.Quantum.Canon.MultiM));
            this.QuantumSearch = this.Factory.Get<ICallable<(Int64,Qubit,QArray<Qubit>), QVoid>>(typeof(Microsoft.Quantum.Samples.DatabaseSearch.QuantumSearch));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumExtensionsMathSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sin));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<GroverHardCodedTest, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class DatabaseOracleFromInts : Unitary<(QArray<Int64>,Qubit,QArray<Qubit>)>, ICallable
    {
        public DatabaseOracleFromInts(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Int64>,Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "DatabaseOracleFromInts";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.DatabaseOracleFromInts";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonControlledOnInt
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Qubit,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (markedElements,markedQubit,databaseRegister) = __in;
#line 443 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var nMarked = markedElements.Count;
#line 444 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            foreach (var idxMarked in new Range(0L, (nMarked - 1L)))
            {
                // Note: As X accepts a Qubit, and ControlledOnInt only 
                // accepts Qubit[], we use ApplyToEachCA(X, _) which accepts 
                // Qubit[] even though the target is only 1 Qubit.
#line 448 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], ((IUnitary)MicrosoftQuantumCanonApplyToEachCA.Partial((((IUnitary)MicrosoftQuantumPrimitiveX), _))))).Apply((databaseRegister, new QArray<Qubit>()
                {markedQubit}));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Int64>,Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (markedElements,markedQubit,databaseRegister) = __in;
#line 443 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var nMarked = markedElements.Count;
            foreach (var idxMarked in new Range((0L - ((((nMarked - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                // Note: As X accepts a Qubit, and ControlledOnInt only 
                // accepts Qubit[], we use ApplyToEachCA(X, _) which accepts 
                // Qubit[] even though the target is only 1 Qubit.
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], ((IUnitary)MicrosoftQuantumCanonApplyToEachCA.Partial((((IUnitary)MicrosoftQuantumPrimitiveX), _))))).Adjoint.Apply((databaseRegister, new QArray<Qubit>()
                {markedQubit}));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,Qubit,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(markedElements,markedQubit,databaseRegister)) = __in;
            var nMarked = markedElements.Count;
            foreach (var idxMarked in new Range(0L, (nMarked - 1L)))
            {
                // Note: As X accepts a Qubit, and ControlledOnInt only 
                // accepts Qubit[], we use ApplyToEachCA(X, _) which accepts 
                // Qubit[] even though the target is only 1 Qubit.
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], ((IUnitary)MicrosoftQuantumCanonApplyToEachCA.Partial((((IUnitary)MicrosoftQuantumPrimitiveX), _))))).Controlled.Apply((controlQubits, (databaseRegister, new QArray<Qubit>()
                {markedQubit})));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,Qubit,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(markedElements,markedQubit,databaseRegister)) = __in;
            var nMarked = markedElements.Count;
            foreach (var idxMarked in new Range((0L - ((((nMarked - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                // Note: As X accepts a Qubit, and ControlledOnInt only 
                // accepts Qubit[], we use ApplyToEachCA(X, _) which accepts 
                // Qubit[] even though the target is only 1 Qubit.
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], ((IUnitary)MicrosoftQuantumCanonApplyToEachCA.Partial((((IUnitary)MicrosoftQuantumPrimitiveX), _))))).Adjoint.Controlled.Apply((controlQubits, (databaseRegister, new QArray<Qubit>()
                {markedQubit})));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Int64>,Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Int64> markedElements, Qubit markedQubit, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<DatabaseOracleFromInts, (QArray<Int64>,Qubit,QArray<Qubit>), QVoid>((markedElements, markedQubit, databaseRegister));
        }
    }

    public class GroverStatePrepOracleImpl : Unitary<(QArray<Int64>,Int64,QArray<Qubit>)>, ICallable
    {
        public GroverStatePrepOracleImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Int64>,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "GroverStatePrepOracleImpl";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.GroverStatePrepOracleImpl";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Int64>,Qubit,QArray<Qubit>)> DatabaseOracleFromInts
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonExclude
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Int64,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (markedElements,idxMarkedQubit,startQubits) = __in;
#line 482 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var flagQubit = startQubits[idxMarkedQubit];
#line 483 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var databaseRegister = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {idxMarkedQubit}, startQubits));
            // Apply oracle `U`
#line 486 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((((IUnitary)MicrosoftQuantumPrimitiveH), databaseRegister));
            // Apply oracle `D`
#line 489 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            DatabaseOracleFromInts.Apply((markedElements, flagQubit, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Int64>,Int64,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (markedElements,idxMarkedQubit,startQubits) = __in;
#line 482 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var flagQubit = startQubits[idxMarkedQubit];
#line 483 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var databaseRegister = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {idxMarkedQubit}, startQubits));
            // Apply oracle `U`
            // Apply oracle `D`
            DatabaseOracleFromInts.Adjoint.Apply((markedElements, flagQubit, databaseRegister));
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((((IUnitary)MicrosoftQuantumPrimitiveH), databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,Int64,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(markedElements,idxMarkedQubit,startQubits)) = __in;
            var flagQubit = startQubits[idxMarkedQubit];
            var databaseRegister = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {idxMarkedQubit}, startQubits));
            // Apply oracle `U`
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveH), databaseRegister)));
            // Apply oracle `D`
            DatabaseOracleFromInts.Controlled.Apply((controlQubits, (markedElements, flagQubit, databaseRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,Int64,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(markedElements,idxMarkedQubit,startQubits)) = __in;
            var flagQubit = startQubits[idxMarkedQubit];
            var databaseRegister = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {idxMarkedQubit}, startQubits));
            // Apply oracle `U`
            // Apply oracle `D`
            DatabaseOracleFromInts.Adjoint.Controlled.Apply((controlQubits, (markedElements, flagQubit, databaseRegister)));
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveH), databaseRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.DatabaseOracleFromInts = this.Factory.Get<IUnitary<(QArray<Int64>,Qubit,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Samples.DatabaseSearch.DatabaseOracleFromInts));
            this.MicrosoftQuantumCanonExclude = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Exclude<>));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Int64> markedElements, Int64 idxMarkedQubit, QArray<Qubit> startQubits)
        {
            return __m__.Run<GroverStatePrepOracleImpl, (QArray<Int64>,Int64,QArray<Qubit>), QVoid>((markedElements, idxMarkedQubit, startQubits));
        }
    }

    public class GroverStatePrepOracle : Operation<QArray<Int64>, IUnitary>, ICallable
    {
        public GroverStatePrepOracle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GroverStatePrepOracle";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.GroverStatePrepOracle";
        protected IUnitary<(QArray<Int64>,Int64,QArray<Qubit>)> GroverStatePrepOracleImpl
        {
            get;
            set;
        }

        public override Func<QArray<Int64>, IUnitary> Body => (__in) =>
        {
            var markedElements = __in;
#line 512 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            return new Microsoft.Quantum.Canon.StateOracle(GroverStatePrepOracleImpl.Partial(new Func<(Int64,QArray<Qubit>), (QArray<Int64>,Int64,QArray<Qubit>)>((_arg1) => (markedElements, _arg1.Item1, _arg1.Item2))));
        }

        ;
        public override void Init()
        {
            this.GroverStatePrepOracleImpl = this.Factory.Get<IUnitary<(QArray<Int64>,Int64,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Samples.DatabaseSearch.GroverStatePrepOracleImpl));
        }

        public override IApplyData __dataIn(QArray<Int64> data) => data;
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, QArray<Int64> markedElements)
        {
            return __m__.Run<GroverStatePrepOracle, QArray<Int64>, IUnitary>(markedElements);
        }
    }

    public class GroverSearch : Operation<(QArray<Int64>,Int64,Int64), IUnitary>, ICallable
    {
        public GroverSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64,Int64)>, IApplyData
        {
            public In((QArray<Int64>,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GroverSearch";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.GroverSearch";
        protected ICallable<(Int64,IUnitary,Int64), IUnitary> MicrosoftQuantumCanonAmpAmpByOracle
        {
            get;
            set;
        }

        protected ICallable<QArray<Int64>, IUnitary> GroverStatePrepOracle
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Int64,Int64), IUnitary> Body => (__in) =>
        {
            var (markedElements,nIterations,idxMarkedQubit) = __in;
#line 537 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            return MicrosoftQuantumCanonAmpAmpByOracle.Apply((nIterations, GroverStatePrepOracle.Apply(markedElements), idxMarkedQubit));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAmpAmpByOracle = this.Factory.Get<ICallable<(Int64,IUnitary,Int64), IUnitary>>(typeof(Microsoft.Quantum.Canon.AmpAmpByOracle));
            this.GroverStatePrepOracle = this.Factory.Get<ICallable<QArray<Int64>, IUnitary>>(typeof(Microsoft.Quantum.Samples.DatabaseSearch.GroverStatePrepOracle));
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, QArray<Int64> markedElements, Int64 nIterations, Int64 idxMarkedQubit)
        {
            return __m__.Run<GroverSearch, (QArray<Int64>,Int64,Int64), IUnitary>((markedElements, nIterations, idxMarkedQubit));
        }
    }

    public class ApplyGroverSearch : Operation<(QArray<Int64>,Int64,Int64), (Result,Int64)>, ICallable
    {
        public ApplyGroverSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64,Int64)>, IApplyData
        {
            public In((QArray<Int64>,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Result,Int64)>, IApplyData
        {
            public Out((Result,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ApplyGroverSearch";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ApplyGroverSearch";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,Int64,Int64), IUnitary> GroverSearch
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QArray<Result>> MicrosoftQuantumCanonMultiM
        {
            get;
            set;
        }

        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonPositiveIntFromResultArr
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Int64,Int64), (Result,Int64)> Body => (__in) =>
        {
            var (markedElements,nIterations,nDatabaseQubits) = __in;
            // Allocate variables to store measurement results.
#line 560 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var resultSuccess = Result.Zero;
#line 561 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var numberElement = 0L;
            // Allocate nDatabaseQubits + 1 qubits. These are all in the |0〉
            // state.
#line 565 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var qubits = Allocate.Apply((nDatabaseQubits + 1L));
            // Define marked qubit to be indexed by 0.
#line 568 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var markedQubit = qubits[0L];
            // Let all other qubits be the database register.
#line 571 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var databaseRegister = qubits?.Slice(new Range(1L, nDatabaseQubits));
            // Implement the quantum search algorithm.
#line 574 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            GroverSearch.Apply((markedElements, nIterations, 0L)).Apply(qubits);
            // Measure the marked qubit. On success, this should be One.
#line 577 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            resultSuccess = M.Apply(markedQubit);
            // Measure the state of the database register post-selected on
            // the state of the marked qubit.
#line 581 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            var resultElement = MicrosoftQuantumCanonMultiM.Apply(databaseRegister);
#line 583 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            numberElement = MicrosoftQuantumCanonPositiveIntFromResultArr.Apply(resultElement);
            // These reset all qubits to the |0〉 state, which is required 
            // before deallocation.
#line 587 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
            // Returns the measurement results of the algorithm.
#line 591 "/home/bharath/quantum/DatabaseSearch/DatabaseSearch.qs"
            return (resultSuccess, numberElement);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.GroverSearch = this.Factory.Get<ICallable<(QArray<Int64>,Int64,Int64), IUnitary>>(typeof(Microsoft.Quantum.Samples.DatabaseSearch.GroverSearch));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumCanonMultiM = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Microsoft.Quantum.Canon.MultiM));
            this.MicrosoftQuantumCanonPositiveIntFromResultArr = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.PositiveIntFromResultArr));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut((Result,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,Int64)> Run(IOperationFactory __m__, QArray<Int64> markedElements, Int64 nIterations, Int64 nDatabaseQubits)
        {
            return __m__.Run<ApplyGroverSearch, (QArray<Int64>,Int64,Int64), (Result,Int64)>((markedElements, nIterations, nDatabaseQubits));
        }
    }
}