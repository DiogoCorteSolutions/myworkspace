using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CertificatioTHREADS
{
    public class Program
    {
        static void Main(string[] args)
        {
            UsingWaitWal();
            //UsingTaskFactory();   // TasksRetur();
            //continuationAdding();
            Console.ReadKey();

        }


        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void ThreadTestMethod()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Este e um teste de aplicação de Sistemas");
            }
        }

        public static void StartMethod()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main Thread : Do some work.");
                Thread.Sleep(0);

            }
            t.Join();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("This is test the application software");
                Thread.Sleep(0);
            }


            //Result
            //Displays
            //Main Thread : Do some work
            //ThreadProch : 0
            //Main Thread : Do some work
            //ThreadProch : 1
            //Main Thread : Do some work
            //ThreadProch : 2
            //Main Thread : Do some work
            //ThreadProch : 3
            //ThreadProch : 4
            //ThreadProch : 5
            //ThreadProch : 6
            //ThreadProch : 7
            //ThreadProch : 8
            //ThreadProch : 9


        }

        public static void MethodBackground()
        {

            //start
            //Thread t = new Thread(new ThreadStart(MethodBackground));
            //t.IsBackground = false;
            //t.Start();

            //Thread t = new Thread(new ParameterizedThreadStart(MethodStartProp));
            //t.Start(1);
            //t.Join();

            //Thread t = new Thread(new ThreadStart(MethodBackground));
            //t.IsBackground = false;
            //t.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc : {0}", i);
                Thread.Sleep(3000);
            }
        }

        public static void MethodStartProp(object o)
        {
            for (int i = 0; i < (int)0; i++)
            {
                Console.WriteLine("ThreadProc {0}", i);

                Thread.Sleep(0);
            }

        }

        public static void MethodStoppedProp()
        {
            //bool stopped = false;

            //Thread t = new Thread(new ThreadStart(() =>
            //{
            //    while (!stopped)
            //    {
            //        Console.WriteLine("Runing...");
            //        Thread.Sleep(1000);
            //    }
            //}));
            //t.Start();
            //Console.WriteLine("Press key any");
            //Console.ReadKey();


            //stopped = true;
            //t.Join();
            for (int i = 0; i < (int)0; i++)
            {
                Console.WriteLine("ProcThread {0}", i);
                Thread.Sleep(0);
            }
        }

        public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
        {
            return Thread.CurrentThread.ManagedThreadId;
        });
        public static void start_field()
        {
            new Thread(() =>
            {
                for (int x = 0; x < 9; x++)
                {
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();
            new Thread(() =>
            {
                //for (int x = 0; x < _field.Value; x++)         
                for (int x = 0; x < 8; x++)
                {
                    Console.WriteLine("Thread B: {0}", x);
                }
            });


            //StartMethod();
            Console.ReadKey();

        }

        public static void StarNewThreading()
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write("*");
                }
            });
            t.Wait();
        }

        public static void QueueUserWorkItem()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });
            Console.ReadLine();
            Console.ReadKey();


        }

        public static void MetodThreadTask()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });
            Console.WriteLine(t.Result); //Dysplay 42.
        }

        public static void MethodAdding()
        {
            //Adding a continuation
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });
            Console.WriteLine(t.Result);
        }

        //LISTING 1-11 Scheduling different continuation tasks
        public static void continuationAdding()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });
            t.ContinueWith((i) =>
                        {
                            Console.WriteLine("Canceled");
                        }, TaskContinuationOptions.OnlyOnFaulted);
            t.ContinueWith((i) =>
            {
                Console.WriteLine("Flauted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completeTask = t.ContinueWith((i) =>
            {
                Console.WriteLine("Complete");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);
            completeTask.Wait();
        }

        public static void TasksRetur()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });
            Console.WriteLine(t.Result * 3);
        }

        public static void TaarefasPaFilho()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });
            t.ContinueWith((i) =>
            {
                Console.WriteLine("Cancelado numero 1");
            }, TaskContinuationOptions.OnlyOnCanceled);
            t.ContinueWith((i) =>
            {
                Console.WriteLine("Flutued");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completeTask = t.ContinueWith((i) =>
                        {
                            Console.WriteLine("Complete");
                        }, TaskContinuationOptions.OnlyOnRanToCompletion);
            completeTask.Wait();
        }

        //public static void TaskFactory()
        //{
        //    Task<Int32[]> parent = Task.Run(() =>
        //    {
        //        var result = new Int32[3];
        //        new Task(() = result[0] = 0,
        //            TaskCreationOptions.AttachedToParent).Start();
        //        new Task(() = result[1] = 1,
        //            TaskCreationOptions.AttachedToParent).Start();
        //        new Task(() = result[3] = 3,
        //        TaskCreationOptions.AttachedToParent).Start();

        //        return result;
        //    });

        //    var finalTask = parent.ContinueWith(
        //        ParentTask =>
        //       {
        //           foreach (int i in ParentTask.Result)
        //               Console.WriteLine(i);
        //       });
        //    finalTask.Wait();

        //}

        public static void TaskFactory()
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[8];
                new Task(() => results[0] = 0,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2,
                    TaskCreationOptions.AttachedToParent).Start();
                return results;
            });
            var finalTask = parent.ContinueWith(
                parentTask =>
                {
                    foreach (int i in parentTask.Result)
                    {
                        Console.WriteLine(i);
                    }
                });
            finalTask.Wait();


        }

        public static void UsingTaskFactory()
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var result = new Int32[3];

                TaskFactory tf = new System.Threading.Tasks.TaskFactory(TaskCreationOptions.AttachedToParent,
                    TaskContinuationOptions.ExecuteSynchronously);

                tf.StartNew(() => result[0] = 0);
                tf.StartNew(() => result[1] = 1);
                tf.StartNew(() => result[2] = 2);
                return result;

            });

            var finalTask = parent.ContinueWith(
              ParentTask =>
              {
                  foreach (int i in ParentTask.Result)
                  {
                      Console.WriteLine(i);
                  }
              });
            finalTask.Wait();
        }

        public static void UsingWaitWal()
        {
            Task[] task = new Task[3];

            task[0] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("0");
                return 1;
            });

            task[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("1");
                return 2;
            });

            task[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("2");
            });
            Task.WaitAll(task);


        }
    }
}