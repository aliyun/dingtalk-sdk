// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class CreateOrgHonorRequest : TeaModel {
        /// <summary>
        /// 头像挂件   图片尺寸 240*240，不超过1M，支持PNG。图片请使用钉钉媒体资源标识符media_id，参考文档：https://open.dingtalk.com/document/isvapp-server/upload-media-files
        /// </summary>
        [NameInMap("avatarFrameMediaId")]
        [Validation(Required=false)]
        public string AvatarFrameMediaId { get; set; }

        /// <summary>
        /// 背景颜色，如下可选：#FFFBB4 #FFE7BC #FFDAF4 #DAF6A8 #E4D7FF #BFDFFF #B9F2D6
        /// </summary>
        [NameInMap("defaultBgColor")]
        [Validation(Required=false)]
        public string DefaultBgColor { get; set; }

        /// <summary>
        /// 描述 长度30字符 不支持表情图标等
        /// </summary>
        [NameInMap("medalDesc")]
        [Validation(Required=false)]
        public string MedalDesc { get; set; }

        /// <summary>
        /// 荣誉图片  图片尺寸 900*900，不超过1M，支持PNG 。图片请使用钉钉媒体资源标识符media_id，参考文档：https://open.dingtalk.com/document/isvapp-server/upload-media-files
        /// </summary>
        [NameInMap("medalMediaId")]
        [Validation(Required=false)]
        public string MedalMediaId { get; set; }

        /// <summary>
        /// 组织的勋章名称 长度10字符 不支持表情图标等
        /// </summary>
        [NameInMap("medalName")]
        [Validation(Required=false)]
        public string MedalName { get; set; }

        /// <summary>
        /// 创建荣誉勋章模板人在组织内的userid，需要主/子管理员角色
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
