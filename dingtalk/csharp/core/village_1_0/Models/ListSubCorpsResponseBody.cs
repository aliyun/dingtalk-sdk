// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListSubCorpsResponseBody : TeaModel {
        [NameInMap("corpList")]
        [Validation(Required=false)]
        public List<ListSubCorpsResponseBodyCorpList> CorpList { get; set; }
        public class ListSubCorpsResponseBodyCorpList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("corpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>149 区县，148 乡镇街道，145 村， 150 社区， 151 小区</para>
            /// </summary>
            [NameInMap("industryCode")]
            [Validation(Required=false)]
            public int? IndustryCode { get; set; }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>浙江省_杭州市_余杭区_仓前街道</para>
            /// </summary>
            [NameInMap("regionLocation")]
            [Validation(Required=false)]
            public string RegionLocation { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("regionType")]
            [Validation(Required=false)]
            public string RegionType { get; set; }

        }

    }

}
