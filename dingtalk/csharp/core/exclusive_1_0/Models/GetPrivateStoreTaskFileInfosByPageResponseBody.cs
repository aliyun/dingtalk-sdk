// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetPrivateStoreTaskFileInfosByPageResponseBody : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<GetPrivateStoreTaskFileInfosByPageResponseBodyItems> Items { get; set; }
        public class GetPrivateStoreTaskFileInfosByPageResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>普通文件</para>
            /// </summary>
            [NameInMap("classTagName")]
            [Validation(Required=false)]
            public string ClassTagName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public string DentryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234566</para>
            /// </summary>
            [NameInMap("fileCreateTime")]
            [Validation(Required=false)]
            public long? FileCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>安装包</para>
            /// </summary>
            [NameInMap("fileFormatName")]
            [Validation(Required=false)]
            public string FileFormatName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234566</para>
            /// </summary>
            [NameInMap("fileModifiedTime")]
            [Validation(Required=false)]
            public long? FileModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>我的表格.xls</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>钉钉云盘</para>
            /// </summary>
            [NameInMap("fileScopeName")]
            [Validation(Required=false)]
            public string FileScopeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1GB</para>
            /// </summary>
            [NameInMap("fileSizeName")]
            [Validation(Required=false)]
            public string FileSizeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public long? SpaceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123abc</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
