// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class CreateApproveRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>341lkfjdkf</para>
        /// </summary>
        [NameInMap("approveId")]
        [Validation(Required=false)]
        public string ApproveId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4243235dfd</para>
        /// </summary>
        [NameInMap("opUserid")]
        [Validation(Required=false)]
        public string OpUserid { get; set; }

        [NameInMap("punchParam")]
        [Validation(Required=false)]
        public CreateApproveRequestPunchParam PunchParam { get; set; }
        public class CreateApproveRequestPunchParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>120.023425_30.291465</para>
            /// </summary>
            [NameInMap("positionId")]
            [Validation(Required=false)]
            public string PositionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>余杭区五常街道</para>
            /// </summary>
            [NameInMap("positionName")]
            [Validation(Required=false)]
            public string PositionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>gps</para>
            /// </summary>
            [NameInMap("positionType")]
            [Validation(Required=false)]
            public string PositionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1614222064000</para>
            /// </summary>
            [NameInMap("punchTime")]
            [Validation(Required=false)]
            public long? PunchTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>年假</para>
        /// </summary>
        [NameInMap("subType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>请假</para>
        /// </summary>
        [NameInMap("tagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fdfi3435</para>
        /// </summary>
        [NameInMap("userid")]
        [Validation(Required=false)]
        public string Userid { get; set; }

    }

}
