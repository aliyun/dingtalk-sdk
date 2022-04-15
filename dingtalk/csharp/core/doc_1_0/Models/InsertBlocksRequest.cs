// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class InsertBlocksRequest : TeaModel {
        /// <summary>
        /// 元素数组
        /// </summary>
        [NameInMap("blocks")]
        [Validation(Required=false)]
        public List<InsertBlocksRequestBlocks> Blocks { get; set; }
        public class InsertBlocksRequestBlocks : TeaModel {
            /// <summary>
            /// 元素类型标识
            /// </summary>
            [NameInMap("blockType")]
            [Validation(Required=false)]
            public string BlockType { get; set; }

            /// <summary>
            /// 段落元素
            /// </summary>
            [NameInMap("paragraph")]
            [Validation(Required=false)]
            public InsertBlocksRequestBlocksParagraph Paragraph { get; set; }
            public class InsertBlocksRequestBlocksParagraph : TeaModel {
                [NameInMap("children")]
                [Validation(Required=false)]
                public List<InsertBlocksRequestBlocksParagraphChildren> Children { get; set; }
                public class InsertBlocksRequestBlocksParagraphChildren : TeaModel {
                    public string ElementType { get; set; }
                    public InsertBlocksRequestBlocksParagraphChildrenText Text { get; set; }
                    public class InsertBlocksRequestBlocksParagraphChildrenText : TeaModel {
                        /// <summary>
                        /// 文本内容
                        /// </summary>
                        [NameInMap("content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// 文字样式
                        /// </summary>
                        [NameInMap("textStyle")]
                        [Validation(Required=false)]
                        public InsertBlocksRequestBlocksParagraphChildrenTextTextStyle TextStyle { get; set; }
                        public class InsertBlocksRequestBlocksParagraphChildrenTextTextStyle : TeaModel {
                            [NameInMap("bold")]
                            [Validation(Required=false)]
                            public bool? Bold { get; set; }
                            [NameInMap("dataType")]
                            [Validation(Required=false)]
                            public string DataType { get; set; }
                            [NameInMap("fontSize")]
                            [Validation(Required=false)]
                            public int? FontSize { get; set; }
                            [NameInMap("sizeUnit")]
                            [Validation(Required=false)]
                            public string SizeUnit { get; set; }
                        };

                    }
                }
                [NameInMap("style")]
                [Validation(Required=false)]
                public InsertBlocksRequestBlocksParagraphStyle Style { get; set; }
                public class InsertBlocksRequestBlocksParagraphStyle : TeaModel {
                    /// <summary>
                    /// 标题样式
                    /// </summary>
                    [NameInMap("headingLevel")]
                    [Validation(Required=false)]
                    public string HeadingLevel { get; set; }

                }
            };

        }

        /// <summary>
        /// 位置信息
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public InsertBlocksRequestLocation Location { get; set; }
        public class InsertBlocksRequestLocation : TeaModel {
            [NameInMap("head")]
            [Validation(Required=false)]
            public bool? Head { get; set; }
        };

        /// <summary>
        /// 操作用户unionId
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
