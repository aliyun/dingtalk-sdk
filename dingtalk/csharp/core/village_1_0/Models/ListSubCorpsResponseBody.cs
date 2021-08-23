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
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListSubCorpsResponseBodyResult> Result { get; set; }
        public class ListSubCorpsResponseBodyResult : TeaModel {
            /// <summary>
            /// 企业corpid
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 企业名字
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 区域类型，值为county,town,community,residential，依次为区/县、乡/镇/街道、社区/村、小区
            /// </summary>
            [NameInMap("regionType")]
            [Validation(Required=false)]
            public string RegionType { get; set; }

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
            /// 企业行业码
            /// </summary>
            [NameInMap("industryCode")]
            [Validation(Required=false)]
            public int? IndustryCode { get; set; }

            /// <summary>
            /// 企业行业名称
            /// </summary>
            [NameInMap("industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

        }

    }

}
