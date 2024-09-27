// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GroupQueryByAttrRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("groupTopic")]
        [Validation(Required=false)]
        public string GroupTopic { get; set; }

        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        [NameInMap("listDynamicAttr")]
        [Validation(Required=false)]
        public List<GroupQueryByAttrRequestListDynamicAttr> ListDynamicAttr { get; set; }
        public class GroupQueryByAttrRequestListDynamicAttr : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("attrCode")]
            [Validation(Required=false)]
            public string AttrCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("listAttrOptionsCode")]
            [Validation(Required=false)]
            public List<string> ListAttrOptionsCode { get; set; }

        }

        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("secretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

    }

}
