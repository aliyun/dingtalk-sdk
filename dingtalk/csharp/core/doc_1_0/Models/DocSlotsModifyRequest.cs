// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class DocSlotsModifyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>contentBody</para>
        /// </summary>
        [NameInMap("request")]
        [Validation(Required=false)]
        public List<DocSlotsModifyRequestRequest> Request { get; set; }
        public class DocSlotsModifyRequestRequest : TeaModel {
            [NameInMap("body")]
            [Validation(Required=false)]
            public Dictionary<string, object> Body { get; set; }

            [NameInMap("slotId")]
            [Validation(Required=false)]
            public string SlotId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
