// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class MoveDentriesResponseBody : TeaModel {
        [NameInMap("resultItems")]
        [Validation(Required=false)]
        public List<MoveDentriesResponseBodyResultItems> ResultItems { get; set; }
        public class MoveDentriesResponseBodyResultItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("async")]
            [Validation(Required=false)]
            public bool? Async { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dentry_id</para>
            /// </summary>
            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public string DentryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>permissionDenied</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>space_id</para>
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>target_dentry_id</para>
            /// </summary>
            [NameInMap("targetDentryId")]
            [Validation(Required=false)]
            public string TargetDentryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>target_space_id</para>
            /// </summary>
            [NameInMap("targetSpaceId")]
            [Validation(Required=false)]
            public string TargetSpaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task_id</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
