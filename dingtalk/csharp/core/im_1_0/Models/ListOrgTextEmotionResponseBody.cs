// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class ListOrgTextEmotionResponseBody : TeaModel {
        /// <summary>
        /// 拉取企业文字表情结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListOrgTextEmotionResponseBodyResult Result { get; set; }
        public class ListOrgTextEmotionResponseBodyResult : TeaModel {
            /// <summary>
            /// 企业文字表情列表
            /// </summary>
            [NameInMap("emotions")]
            [Validation(Required=false)]
            public List<ListOrgTextEmotionResponseBodyResultEmotions> Emotions { get; set; }
            public class ListOrgTextEmotionResponseBodyResultEmotions : TeaModel {
                /// <summary>
                /// 展示在消息气泡中的文字表情的mediaId
                /// </summary>
                [NameInMap("backgroundMediaId")]
                [Validation(Required=false)]
                public string BackgroundMediaId { get; set; }

                /// <summary>
                /// 展示在消息长按菜单中的文字表情的mediaId
                /// </summary>
                [NameInMap("backgroundMediaIdForPanel")]
                [Validation(Required=false)]
                public string BackgroundMediaIdForPanel { get; set; }

                /// <summary>
                /// 表情所属部门Id：
                /// -1：该表情为企业层面的文字表情
                /// 一级部门Id：该表情为一级部门层面的文字表情
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                /// <summary>
                /// 表情Id
                /// </summary>
                [NameInMap("emotionId")]
                [Validation(Required=false)]
                public string EmotionId { get; set; }

                /// <summary>
                /// 表情名称，对用户不可见
                /// </summary>
                [NameInMap("emotionName")]
                [Validation(Required=false)]
                public string EmotionName { get; set; }

                /// <summary>
                /// 表情状态
                /// 0：已删除
                /// 1：可用
                /// 2：安全审核不通过
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
