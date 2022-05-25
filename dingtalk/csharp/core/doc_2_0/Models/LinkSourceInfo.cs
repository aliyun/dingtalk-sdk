// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class LinkSourceInfo : TeaModel {
        /// <summary>
        /// 快捷方式关联的源文件后缀。
        /// </summary>
        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        /// <summary>
        /// 非通用快捷方式的图标信息。
        /// </summary>
        [NameInMap("iconUrl")]
        [Validation(Required=false)]
        public LinkSourceInfoIconUrl IconUrl { get; set; }
        public class LinkSourceInfoIconUrl : TeaModel {
            [NameInMap("line")]
            [Validation(Required=false)]
            public string Line { get; set; }
            [NameInMap("small")]
            [Validation(Required=false)]
            public string Small { get; set; }
        };

        /// <summary>
        /// 快捷方式关联的源文件ID（空间内唯一）。
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// 快捷方式类型。0-通用快捷方式；1-闪会快捷方式；2-日志快捷方式；3-闪会2.0快捷方式。
        /// </summary>
        [NameInMap("linkType")]
        [Validation(Required=false)]
        public long? LinkType { get; set; }

        /// <summary>
        /// 快捷方式关联的源文件所属空间id。
        /// </summary>
        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

    }

}
