// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UpdateRangeRequest extends TeaModel {
    /**
     * <p>背景色</p>
     * <p>最大size:</p>
     * <p>	1000</p>
     */
    @NameInMap("backgroundColors")
    public java.util.List<java.util.List<String>> backgroundColors;

    /**
     * <p>超链接</p>
     * <p>最大size:</p>
     * <p>	1000</p>
     */
    @NameInMap("hyperlinks")
    public java.util.List<java.util.List<UpdateRangeRequestHyperlinks>> hyperlinks;

    /**
     * <p>数字格式</p>
     */
    @NameInMap("numberFormat")
    public String numberFormat;

    /**
     * <p>值</p>
     * <p>最大size:</p>
     * <p>	1000</p>
     */
    @NameInMap("values")
    public java.util.List<java.util.List<String>> values;

    /**
     * <p>操作人id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static UpdateRangeRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateRangeRequest self = new UpdateRangeRequest();
        return TeaModel.build(map, self);
    }

    public UpdateRangeRequest setBackgroundColors(java.util.List<java.util.List<String>> backgroundColors) {
        this.backgroundColors = backgroundColors;
        return this;
    }
    public java.util.List<java.util.List<String>> getBackgroundColors() {
        return this.backgroundColors;
    }

    public UpdateRangeRequest setHyperlinks(java.util.List<java.util.List<UpdateRangeRequestHyperlinks>> hyperlinks) {
        this.hyperlinks = hyperlinks;
        return this;
    }
    public java.util.List<java.util.List<UpdateRangeRequestHyperlinks>> getHyperlinks() {
        return this.hyperlinks;
    }

    public UpdateRangeRequest setNumberFormat(String numberFormat) {
        this.numberFormat = numberFormat;
        return this;
    }
    public String getNumberFormat() {
        return this.numberFormat;
    }

    public UpdateRangeRequest setValues(java.util.List<java.util.List<String>> values) {
        this.values = values;
        return this;
    }
    public java.util.List<java.util.List<String>> getValues() {
        return this.values;
    }

    public UpdateRangeRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class UpdateRangeRequestHyperlinks extends TeaModel {
        /**
         * <p>超链接类型，可选path、sheet、range</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <p>超链接地址</p>
         */
        @NameInMap("link")
        public String link;

        /**
         * <p>超链接文本</p>
         */
        @NameInMap("text")
        public String text;

        public static UpdateRangeRequestHyperlinks build(java.util.Map<String, ?> map) throws Exception {
            UpdateRangeRequestHyperlinks self = new UpdateRangeRequestHyperlinks();
            return TeaModel.build(map, self);
        }

        public UpdateRangeRequestHyperlinks setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public UpdateRangeRequestHyperlinks setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public UpdateRangeRequestHyperlinks setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

}
