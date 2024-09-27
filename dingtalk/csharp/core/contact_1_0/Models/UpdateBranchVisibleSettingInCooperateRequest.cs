// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UpdateBranchVisibleSettingInCooperateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpdateBranchVisibleSettingInCooperateRequestBody> Body { get; set; }
        public class UpdateBranchVisibleSettingInCooperateRequestBody : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ding1234</para>
            /// </summary>
            [NameInMap("branchCorpId")]
            [Validation(Required=false)]
            public string BranchCorpId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("open")]
            [Validation(Required=false)]
            public bool? Open { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public long? Type { get; set; }

            [NameInMap("visibleBranchCorpIds")]
            [Validation(Required=false)]
            public List<string> VisibleBranchCorpIds { get; set; }

            [NameInMap("visibleDeptIds")]
            [Validation(Required=false)]
            public List<long?> VisibleDeptIds { get; set; }

        }

    }

}
