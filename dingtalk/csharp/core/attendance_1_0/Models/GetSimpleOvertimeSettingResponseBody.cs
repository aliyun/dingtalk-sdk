// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetSimpleOvertimeSettingResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetSimpleOvertimeSettingResponseBodyResult> Result { get; set; }
        public class GetSimpleOvertimeSettingResponseBodyResult : TeaModel {
            /// <summary>
            /// 加班规则集合
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetSimpleOvertimeSettingResponseBodyResultItems> Items { get; set; }
            public class GetSimpleOvertimeSettingResponseBodyResultItems : TeaModel {
                /// <summary>
                /// 加班规则id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// 加班规则名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("settingId")]
                [Validation(Required=false)]
                public long? SettingId { get; set; }

            }

            /// <summary>
            /// 当前页码
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// 总页数
            /// </summary>
            [NameInMap("totalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

        }

    }

}
