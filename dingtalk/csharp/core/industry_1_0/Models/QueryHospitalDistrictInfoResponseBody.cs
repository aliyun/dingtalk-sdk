// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryHospitalDistrictInfoResponseBody : TeaModel {
        /// <summary>
        /// 院区病区详情
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryHospitalDistrictInfoResponseBodyContent> Content { get; set; }
        public class QueryHospitalDistrictInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// 主键
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 院区或病区名称
            /// </summary>
            [NameInMap("districtName")]
            [Validation(Required=false)]
            public string DistrictName { get; set; }

            /// <summary>
            /// 类型，1：院区；2：病区
            /// </summary>
            [NameInMap("districtType")]
            [Validation(Required=false)]
            public int? DistrictType { get; set; }

            /// <summary>
            /// 院区id
            /// </summary>
            [NameInMap("parentDistrictId")]
            [Validation(Required=false)]
            public long? ParentDistrictId { get; set; }

            /// <summary>
            /// 病区对应的物理地址
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// 删除，0:正常，其他：已删除
            /// </summary>
            [NameInMap("deleted")]
            [Validation(Required=false)]
            public int? Deleted { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

        }

        /// <summary>
        /// 当前页码
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// 数据总量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [NameInMap("totalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
