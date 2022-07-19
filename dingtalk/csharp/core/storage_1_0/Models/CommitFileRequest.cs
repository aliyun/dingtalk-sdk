// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class CommitFileRequest : TeaModel {
        /// <summary>
        /// 名称, 规则：
        /// 1. 头尾不能包含空格，否则会自动去除
        /// 2. 不能包含特殊字符，包括：制表符、*、"、<、>、|
        /// 3. 不能以"."结尾
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 可选参数
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public CommitFileRequestOption Option { get; set; }
        public class CommitFileRequestOption : TeaModel {
            [NameInMap("appProperties")]
            [Validation(Required=false)]
            public List<CommitFileRequestOptionAppProperties> AppProperties { get; set; }
            public class CommitFileRequestOptionAppProperties : TeaModel {
                public string Name { get; set; }
                public string Value { get; set; }
                public string Visibility { get; set; }
            }
            [NameInMap("conflictStrategy")]
            [Validation(Required=false)]
            public string ConflictStrategy { get; set; }
        };

        /// <summary>
        /// 父目录id, 根目录id值为0
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// 大小
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// 添加文件唯一标识，可通过DentryService.getUploadInfo来生成
        /// </summary>
        [NameInMap("uploadKey")]
        [Validation(Required=false)]
        public string UploadKey { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
