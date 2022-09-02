// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetFormDataByIDResponseBody : TeaModel {
        /// <summary>
        /// 表单数据详情
        /// </summary>
        [NameInMap("formData")]
        [Validation(Required=false)]
        public Dictionary<string, object> FormData { get; set; }

        /// <summary>
        /// 表单实例ID
        /// </summary>
        [NameInMap("formInstId")]
        [Validation(Required=false)]
        public string FormInstId { get; set; }

        /// <summary>
        /// 表单ID
        /// </summary>
        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [NameInMap("modifiedTimeGMT")]
        [Validation(Required=false)]
        public string ModifiedTimeGMT { get; set; }

        /// <summary>
        /// 发起人详情
        /// </summary>
        [NameInMap("originator")]
        [Validation(Required=false)]
        public GetFormDataByIDResponseBodyOriginator Originator { get; set; }
        public class GetFormDataByIDResponseBodyOriginator : TeaModel {
            /// <summary>
            /// 部门名称
            /// </summary>
            [NameInMap("departmentName")]
            [Validation(Required=false)]
            public string DepartmentName { get; set; }

            /// <summary>
            /// 邮箱
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// 用户名
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public GetFormDataByIDResponseBodyOriginatorName Name { get; set; }
            public class GetFormDataByIDResponseBodyOriginatorName : TeaModel {
                /// <summary>
                /// 中文名称
                /// </summary>
                [NameInMap("nameInChinese")]
                [Validation(Required=false)]
                public string NameInChinese { get; set; }

                /// <summary>
                /// 英文名称
                /// </summary>
                [NameInMap("nameInEnglish")]
                [Validation(Required=false)]
                public string NameInEnglish { get; set; }

                /// <summary>
                /// 国际化
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// 用户工号
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
