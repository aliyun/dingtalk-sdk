// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateGroupConversationRequest : TeaModel {
        [NameInMap("appUserIds")]
        [Validation(Required=false)]
        public List<string> AppUserIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>http://***.png</para>
        /// </summary>
        [NameInMap("groupAvatar")]
        [Validation(Required=false)]
        public string GroupAvatar { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>客户群</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1745****8777</para>
        /// </summary>
        [NameInMap("groupOwnerId")]
        [Validation(Required=false)]
        public string GroupOwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("groupOwnerType")]
        [Validation(Required=false)]
        public int? GroupOwnerType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8d42****nkld</para>
        /// </summary>
        [NameInMap("groupTemplateId")]
        [Validation(Required=false)]
        public string GroupTemplateId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1745****8777</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
