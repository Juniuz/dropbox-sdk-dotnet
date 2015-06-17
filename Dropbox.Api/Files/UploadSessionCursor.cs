// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>Arguments for <see
    /// cref="Dropbox.Api.Files.Routes.FilesRoutes.UploadSessionAppendAsync" />. Also used by
    /// <see cref="Dropbox.Api.Files.Routes.FilesRoutes.UploadSessionFinishAsync" />.</para>
    /// </summary>
    /// <seealso cref="UploadSessionFinishArg" />
    public sealed class UploadSessionCursor : enc.IEncodable<UploadSessionCursor>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionCursor" />
        /// class.</para>
        /// </summary>
        /// <param name="sessionId">The upload session ID (returned by <see
        /// cref="Dropbox.Api.Files.Routes.FilesRoutes.UploadSessionStartAsync" />).</param>
        /// <param name="offset">The amount of data that has been uploaded so far. We use this
        /// to make sure upload data isn't lost or duplicated in the event of a network
        /// error.</param>
        public UploadSessionCursor(string sessionId,
                                   ulong offset)
        {
            if (sessionId == null)
            {
                throw new sys.ArgumentNullException("sessionId");
            }

            this.SessionId = sessionId;
            this.Offset = offset;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionCursor" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public UploadSessionCursor()
        {
        }

        /// <summary>
        /// <para>The upload session ID (returned by <see
        /// cref="Dropbox.Api.Files.Routes.FilesRoutes.UploadSessionStartAsync" />).</para>
        /// </summary>
        public string SessionId { get; private set; }

        /// <summary>
        /// <para>The amount of data that has been uploaded so far. We use this to make sure
        /// upload data isn't lost or duplicated in the event of a network error.</para>
        /// </summary>
        public ulong Offset { get; private set; }

        #region IEncodable<UploadSessionCursor> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<UploadSessionCursor>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<string>("session_id", this.SessionId);
                obj.AddField<ulong>("offset", this.Offset);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        UploadSessionCursor enc.IEncodable<UploadSessionCursor>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.SessionId = obj.GetField<string>("session_id");
                this.Offset = obj.GetField<ulong>("offset");
            }

            return this;
        }

        #endregion
    }
}