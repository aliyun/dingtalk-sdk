// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class InsertBlocksRequest extends TeaModel {
    /**
     * <p>元素数组</p>
     */
    @NameInMap("blocks")
    public java.util.List<InsertBlocksRequestBlocks> blocks;

    /**
     * <p>位置信息</p>
     */
    @NameInMap("location")
    public InsertBlocksRequestLocation location;

    /**
     * <p>操作用户unionId</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static InsertBlocksRequest build(java.util.Map<String, ?> map) throws Exception {
        InsertBlocksRequest self = new InsertBlocksRequest();
        return TeaModel.build(map, self);
    }

    public InsertBlocksRequest setBlocks(java.util.List<InsertBlocksRequestBlocks> blocks) {
        this.blocks = blocks;
        return this;
    }
    public java.util.List<InsertBlocksRequestBlocks> getBlocks() {
        return this.blocks;
    }

    public InsertBlocksRequest setLocation(InsertBlocksRequestLocation location) {
        this.location = location;
        return this;
    }
    public InsertBlocksRequestLocation getLocation() {
        return this.location;
    }

    public InsertBlocksRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class InsertBlocksRequestBlocksParagraphChildrenTextTextStyle extends TeaModel {
        /**
         * <p>是否加粗</p>
         */
        @NameInMap("bold")
        public Boolean bold;

        /**
         * <p>数据类型</p>
         */
        @NameInMap("dataType")
        public String dataType;

        /**
         * <p>字体大小</p>
         */
        @NameInMap("fontSize")
        public Integer fontSize;

        /**
         * <p>字体大小单位</p>
         */
        @NameInMap("sizeUnit")
        public String sizeUnit;

        public static InsertBlocksRequestBlocksParagraphChildrenTextTextStyle build(java.util.Map<String, ?> map) throws Exception {
            InsertBlocksRequestBlocksParagraphChildrenTextTextStyle self = new InsertBlocksRequestBlocksParagraphChildrenTextTextStyle();
            return TeaModel.build(map, self);
        }

        public InsertBlocksRequestBlocksParagraphChildrenTextTextStyle setBold(Boolean bold) {
            this.bold = bold;
            return this;
        }
        public Boolean getBold() {
            return this.bold;
        }

        public InsertBlocksRequestBlocksParagraphChildrenTextTextStyle setDataType(String dataType) {
            this.dataType = dataType;
            return this;
        }
        public String getDataType() {
            return this.dataType;
        }

        public InsertBlocksRequestBlocksParagraphChildrenTextTextStyle setFontSize(Integer fontSize) {
            this.fontSize = fontSize;
            return this;
        }
        public Integer getFontSize() {
            return this.fontSize;
        }

        public InsertBlocksRequestBlocksParagraphChildrenTextTextStyle setSizeUnit(String sizeUnit) {
            this.sizeUnit = sizeUnit;
            return this;
        }
        public String getSizeUnit() {
            return this.sizeUnit;
        }

    }

    public static class InsertBlocksRequestBlocksParagraphChildrenText extends TeaModel {
        /**
         * <p>文本内容</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <p>文字样式</p>
         */
        @NameInMap("textStyle")
        public InsertBlocksRequestBlocksParagraphChildrenTextTextStyle textStyle;

        public static InsertBlocksRequestBlocksParagraphChildrenText build(java.util.Map<String, ?> map) throws Exception {
            InsertBlocksRequestBlocksParagraphChildrenText self = new InsertBlocksRequestBlocksParagraphChildrenText();
            return TeaModel.build(map, self);
        }

        public InsertBlocksRequestBlocksParagraphChildrenText setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public InsertBlocksRequestBlocksParagraphChildrenText setTextStyle(InsertBlocksRequestBlocksParagraphChildrenTextTextStyle textStyle) {
            this.textStyle = textStyle;
            return this;
        }
        public InsertBlocksRequestBlocksParagraphChildrenTextTextStyle getTextStyle() {
            return this.textStyle;
        }

    }

    public static class InsertBlocksRequestBlocksParagraphChildren extends TeaModel {
        /**
         * <p>元素类型</p>
         */
        @NameInMap("elementType")
        public String elementType;

        /**
         * <p>文本元素</p>
         */
        @NameInMap("text")
        public InsertBlocksRequestBlocksParagraphChildrenText text;

        public static InsertBlocksRequestBlocksParagraphChildren build(java.util.Map<String, ?> map) throws Exception {
            InsertBlocksRequestBlocksParagraphChildren self = new InsertBlocksRequestBlocksParagraphChildren();
            return TeaModel.build(map, self);
        }

        public InsertBlocksRequestBlocksParagraphChildren setElementType(String elementType) {
            this.elementType = elementType;
            return this;
        }
        public String getElementType() {
            return this.elementType;
        }

        public InsertBlocksRequestBlocksParagraphChildren setText(InsertBlocksRequestBlocksParagraphChildrenText text) {
            this.text = text;
            return this;
        }
        public InsertBlocksRequestBlocksParagraphChildrenText getText() {
            return this.text;
        }

    }

    public static class InsertBlocksRequestBlocksParagraphStyle extends TeaModel {
        /**
         * <p>标题样式</p>
         */
        @NameInMap("headingLevel")
        public String headingLevel;

        public static InsertBlocksRequestBlocksParagraphStyle build(java.util.Map<String, ?> map) throws Exception {
            InsertBlocksRequestBlocksParagraphStyle self = new InsertBlocksRequestBlocksParagraphStyle();
            return TeaModel.build(map, self);
        }

        public InsertBlocksRequestBlocksParagraphStyle setHeadingLevel(String headingLevel) {
            this.headingLevel = headingLevel;
            return this;
        }
        public String getHeadingLevel() {
            return this.headingLevel;
        }

    }

    public static class InsertBlocksRequestBlocksParagraph extends TeaModel {
        /**
         * <p>子节点</p>
         */
        @NameInMap("children")
        public java.util.List<InsertBlocksRequestBlocksParagraphChildren> children;

        /**
         * <p>段落样式</p>
         */
        @NameInMap("style")
        public InsertBlocksRequestBlocksParagraphStyle style;

        public static InsertBlocksRequestBlocksParagraph build(java.util.Map<String, ?> map) throws Exception {
            InsertBlocksRequestBlocksParagraph self = new InsertBlocksRequestBlocksParagraph();
            return TeaModel.build(map, self);
        }

        public InsertBlocksRequestBlocksParagraph setChildren(java.util.List<InsertBlocksRequestBlocksParagraphChildren> children) {
            this.children = children;
            return this;
        }
        public java.util.List<InsertBlocksRequestBlocksParagraphChildren> getChildren() {
            return this.children;
        }

        public InsertBlocksRequestBlocksParagraph setStyle(InsertBlocksRequestBlocksParagraphStyle style) {
            this.style = style;
            return this;
        }
        public InsertBlocksRequestBlocksParagraphStyle getStyle() {
            return this.style;
        }

    }

    public static class InsertBlocksRequestBlocks extends TeaModel {
        /**
         * <p>元素类型标识</p>
         */
        @NameInMap("blockType")
        public String blockType;

        /**
         * <p>段落元素</p>
         */
        @NameInMap("paragraph")
        public InsertBlocksRequestBlocksParagraph paragraph;

        public static InsertBlocksRequestBlocks build(java.util.Map<String, ?> map) throws Exception {
            InsertBlocksRequestBlocks self = new InsertBlocksRequestBlocks();
            return TeaModel.build(map, self);
        }

        public InsertBlocksRequestBlocks setBlockType(String blockType) {
            this.blockType = blockType;
            return this;
        }
        public String getBlockType() {
            return this.blockType;
        }

        public InsertBlocksRequestBlocks setParagraph(InsertBlocksRequestBlocksParagraph paragraph) {
            this.paragraph = paragraph;
            return this;
        }
        public InsertBlocksRequestBlocksParagraph getParagraph() {
            return this.paragraph;
        }

    }

    public static class InsertBlocksRequestLocation extends TeaModel {
        /**
         * <p>头部插入</p>
         */
        @NameInMap("head")
        public Boolean head;

        public static InsertBlocksRequestLocation build(java.util.Map<String, ?> map) throws Exception {
            InsertBlocksRequestLocation self = new InsertBlocksRequestLocation();
            return TeaModel.build(map, self);
        }

        public InsertBlocksRequestLocation setHead(Boolean head) {
            this.head = head;
            return this;
        }
        public Boolean getHead() {
            return this.head;
        }

    }

}
