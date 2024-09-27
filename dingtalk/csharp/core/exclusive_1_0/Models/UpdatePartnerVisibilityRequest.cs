// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class UpdatePartnerVisibilityRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0.5</para>
        /// </summary>
        [NameInMap("deptIds")]
        [Validation(Required=false)]
        public List<long?> DeptIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1312312</para>
        /// </summary>
        [NameInMap("labelId")]
        [Validation(Required=false)]
        public long? LabelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500000003</para>
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
