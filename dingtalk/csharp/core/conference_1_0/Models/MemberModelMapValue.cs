// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class MemberModelMapValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>654058f2411fe90147e68780</para>
        /// </summary>
        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试昵称</para>
        /// </summary>
        [NameInMap("userNick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1699347295876</para>
        /// </summary>
        [NameInMap("joinTime")]
        [Validation(Required=false)]
        public long? JoinTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1699347395876</para>
        /// </summary>
        [NameInMap("leaveTime")]
        [Validation(Required=false)]
        public long? LeaveTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1：初始化  2：呼叫中  3：活跃（在会）  4：入会失败（拒接等）  5：被踢  6：离会</para>
        /// </summary>
        [NameInMap("attendStatus")]
        [Validation(Required=false)]
        public int? AttendStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true：是  false：否</para>
        /// </summary>
        [NameInMap("host")]
        [Validation(Required=false)]
        public bool? Host { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true：是  false：否</para>
        /// </summary>
        [NameInMap("coHost")]
        [Validation(Required=false)]
        public bool? CoHost { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true：是  false：否</para>
        /// </summary>
        [NameInMap("outerOrgMember")]
        [Validation(Required=false)]
        public bool? OuterOrgMember { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true：是  false：否</para>
        /// </summary>
        [NameInMap("pstnJoin")]
        [Validation(Required=false)]
        public bool? PstnJoin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Win Mac iOS Android</para>
        /// </summary>
        [NameInMap("deviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

    }

}
