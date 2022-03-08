// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListSubCorpsResponseBody : TeaModel {
        /// <summary>
        /// result
        /// </summary>
        [NameInMap("corpList")]
        [Validation(Required=false)]
        public List<ListSubCorpsResponseBodyCorpList> CorpList { get; set; }
        public class ListSubCorpsResponseBodyCorpList : TeaModel {
            /// <summary>
            /// 组织corpid
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 组织名字
            /// </summary>
            [NameInMap("corpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// 组织行业名称
            /// </summary>
            [NameInMap("industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            /// <summary>
            /// 组织行业码
            /// </summary>
            [NameInMap("industryCode")]
            [Validation(Required=false)]
            public int? IndustryCode { get; set; }

            /// <summary>
            /// 区域码
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// 区域详细信息
            /// </summary>
            [NameInMap("regionLocation")]
            [Validation(Required=false)]
            public string RegionLocation { get; set; }

            /// <summary>
            /// 区域类型，值为county,town,community,residential，依次为区/县、乡/镇/街道、社区/村、小区
            /// </summary>
            [NameInMap("regionType")]
            [Validation(Required=false)]
            public string RegionType { get; set; }

        }

    }

}
