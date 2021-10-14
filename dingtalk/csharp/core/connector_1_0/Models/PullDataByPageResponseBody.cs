// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class PullDataByPageResponseBody : TeaModel {
        /// <summary>
        /// resultList
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<PullDataByPageResponseBodyList> List { get; set; }
        public class PullDataByPageResponseBodyList : TeaModel {
            /// <summary>
            /// 数据创建时间。
            /// </summary>
            [NameInMap("dataGmtCreate")]
            [Validation(Required=false)]
            public long? DataGmtCreate { get; set; }

            /// <summary>
            /// 数据最后修改时间。
            /// </summary>
            [NameInMap("dataGmtModified")]
            [Validation(Required=false)]
            public long? DataGmtModified { get; set; }

            /// <summary>
            /// 创建数据的应用类型，isv应用为premium_microapp。
            /// </summary>
            [NameInMap("dataCreateAppType")]
            [Validation(Required=false)]
            public string DataCreateAppType { get; set; }

            /// <summary>
            /// 创建数据的应用id。
            /// </summary>
            [NameInMap("dataCreateAppId")]
            [Validation(Required=false)]
            public string DataCreateAppId { get; set; }

            /// <summary>
            /// 最后修改数据的应用类型，取值同dataCreateAppType。
            /// </summary>
            [NameInMap("dataModifiedAppType")]
            [Validation(Required=false)]
            public string DataModifiedAppType { get; set; }

            /// <summary>
            /// 最后修改数据的应用id。
            /// </summary>
            [NameInMap("dataModifiedAppId")]
            [Validation(Required=false)]
            public string DataModifiedAppId { get; set; }

            /// <summary>
            /// 数据完整内容。
            /// </summary>
            [NameInMap("jsonData")]
            [Validation(Required=false)]
            public string JsonData { get; set; }

        }

        /// <summary>
        /// 单次获取的最大记录条数。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// 用于查看下一页数据的游标，如果为空则说明没有更多数据了。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
