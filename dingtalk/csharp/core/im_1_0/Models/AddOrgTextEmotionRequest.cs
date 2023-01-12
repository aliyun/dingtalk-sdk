// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class AddOrgTextEmotionRequest : TeaModel {
        /// <summary>
        /// 展示在消息气泡上的表情的mediaId，mediaId可以通过使用文件上传接口上传表情图片得到，图片上限为500KB。
        /// 
        /// 请严格按照表情设计规范设计表情，服务端会检查图片的大小、宽度、高度是否符合规范。
        /// </summary>
        [NameInMap("backgroundMediaId")]
        [Validation(Required=false)]
        public string BackgroundMediaId { get; set; }

        /// <summary>
        /// 展示在消息长按菜单的表情的mediaId，mediaId可以通过使用文件上传接口上传表情图片得到，图片上限为500KB。
        /// 
        /// 请严格按照表情设计规范设计表情，服务端会检查图片的大小、宽度、高度是否符合规范。
        /// </summary>
        [NameInMap("backgroundMediaIdForPanel")]
        [Validation(Required=false)]
        public string BackgroundMediaIdForPanel { get; set; }

        /// <summary>
        /// 部门Id，设置规则：
        /// 
        /// -1：当添加企业层面的文字表情时使用-1，此时表情对企业内所有员工可见
        /// 
        /// 一级部门Id：当添加一级部门层面的文字表情时使用一级部门Id，此时表情对该一级部门及该一级部门下的所有子部门的员工可见
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        /// <summary>
        /// 表情名称，对用户不可见
        /// </summary>
        [NameInMap("emotionName")]
        [Validation(Required=false)]
        public string EmotionName { get; set; }

    }

}
