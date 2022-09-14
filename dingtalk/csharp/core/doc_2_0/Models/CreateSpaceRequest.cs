// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CreateSpaceRequest : TeaModel {
        /// <summary>
        /// 知识库简介。
        /// 最大长度50。
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 知识库图标。
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// 知识库名称。
        /// 最大长度50。
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 操作人unionId。
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 知识库分组id。只有选择了所属小组的情况下，才需要设置知识库分组。
        /// </summary>
        [NameInMap("sectionId")]
        [Validation(Required=false)]
        public string SectionId { get; set; }

        /// <summary>
        /// 公开范围。
        /// </summary>
        [NameInMap("shareScope")]
        [Validation(Required=false)]
        public CreateSpaceRequestShareScope ShareScope { get; set; }
        public class CreateSpaceRequestShareScope : TeaModel {
            /// <summary>
            /// 公开范围。
            /// 0-仅知识库成员可见；
            /// 1-当前组织所有人可见。
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public int? Scope { get; set; }

        }

        /// <summary>
        /// 所属小组id。
        /// </summary>
        [NameInMap("teamId")]
        [Validation(Required=false)]
        public string TeamId { get; set; }

    }

}
