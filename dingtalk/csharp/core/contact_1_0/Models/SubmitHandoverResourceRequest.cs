// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class SubmitHandoverResourceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<SubmitHandoverResourceRequestTasks> Tasks { get; set; }
        public class SubmitHandoverResourceRequestTasks : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>handover</para>
            /// </summary>
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>userIdYYY</para>
            /// </summary>
            [NameInMap("receiverStaffId")]
            [Validation(Required=false)]
            public string ReceiverStaffId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("resourceTypeId")]
            [Validation(Required=false)]
            public long? ResourceTypeId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userIdXXX</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
