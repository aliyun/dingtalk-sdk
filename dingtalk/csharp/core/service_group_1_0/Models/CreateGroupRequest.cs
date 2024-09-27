// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class CreateGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PID123cjj2</para>
        /// </summary>
        [NameInMap("groupBizId")]
        [Validation(Required=false)]
        public string GroupBizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试服务群</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("groupTagNames")]
        [Validation(Required=false)]
        public List<string> GroupTagNames { get; set; }

        [NameInMap("memberStaffIds")]
        [Validation(Required=false)]
        public List<string> MemberStaffIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jciwnfw</para>
        /// </summary>
        [NameInMap("openGroupSetId")]
        [Validation(Required=false)]
        public string OpenGroupSetId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jciwnfw</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager123</para>
        /// </summary>
        [NameInMap("ownerStaffId")]
        [Validation(Required=false)]
        public string OwnerStaffId { get; set; }

    }

}
