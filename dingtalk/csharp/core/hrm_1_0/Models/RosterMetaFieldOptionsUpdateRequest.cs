// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class RosterMetaFieldOptionsUpdateRequest : TeaModel {
        [NameInMap("appAgentId")]
        [Validation(Required=false)]
        public long? AppAgentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sys05-contractType</para>
        /// </summary>
        [NameInMap("fieldCode")]
        [Validation(Required=false)]
        public string FieldCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sys05</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OPTIONS_ADD</para>
        /// </summary>
        [NameInMap("modifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

    }

}
