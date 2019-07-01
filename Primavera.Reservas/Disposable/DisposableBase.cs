using System;

namespace Primavera.ReservasStock
{
    /// <summary>
    /// Base class for disposable classes.
    /// </summary>
    public abstract class DisposableBase: IDisposable
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DisposableBase"/> class.
        /// </summary>
        protected DisposableBase()
            : base()
        {
            // Track disposed state
            this.Disposed = false;
        }

        #endregion

        #region Destructor

        /// <summary>
        /// Finalizes an instance of the <see cref="DisposableBase"/> class.
        /// </summary>
        /// <remarks>
        /// Releases unmanaged resources and performs other cleanup operations before the
        /// <see cref="DisposableBase"/> is reclaimed by garbage collection.
        /// This destructor will run only if the Dispose method does not get called.
        /// It gives your base class the opportunity to finalize.
        /// Leave out the <c>finalizer</c> altogether if this class doesn't own unmanaged resources itself,
        /// but leave the other methods exactly as they are.
        /// </remarks>
        ~DisposableBase()
        {
            this.Dispose(false);
        }

        #endregion

        #region Protected Properties

        /// <summary>
        /// Gets or sets a value indicating whether this instance is disposed.
        /// </summary>
        protected bool Disposed { get; set; }

        #endregion

        #region IDisposable Members

        /// <summary>
        /// Called whenever the object instance needs to clean up the memory used by this component.
        /// A derived class should not be able to override this method.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);

            // This object will be cleaned up by the Dispose method.
            // Therefore, you should call GC.SupressFinalize to take this object off the finalization queue
            // and prevent finalization code for this object from executing a second time.

            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Called whenever the object instance needs to clean up.
        /// Releases unmanaged and managed resources (optionally).
        /// <c>Dispose(bool disposing)</c> executes in two distinct scenarios:
        /// If disposing equals true, the method has been called directly or indirectly by a user's code. 
        /// - Managed and unmanaged resources can be disposed. 
        /// If disposing equals false, the method has been called by the runtime from inside the <c>finalizer</c> and you should not reference other objects.
        /// - Only unmanaged resources can be disposed.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called

            if (!this.Disposed)
            {
                // Dispose managed resources

                if (disposing)
                {
                    // Insert your code here:
                    // - Dispose of managed objects
                    // - Set null references of managed objects
                    // - Unsubscribe of all managed objects events
                }

                // Dispose unmanaged resources

                // Insert your code here:
                // - Free your own state of unmanaged objects
                // - Release pointers to unmanaged window handles
                // - Set null references of unmanaged objects
                // - Set null of large fields
                // - Set null of delegates and events exposed to COM

                // Update disposing state

                this.Disposed = true;

                // Force GC (optional, if you want to force it now)
                // GC.Collect();
                // GC.WaitForPendingFinalizers();
                GC.Collect();
            }
        }

        #endregion
    }
}
