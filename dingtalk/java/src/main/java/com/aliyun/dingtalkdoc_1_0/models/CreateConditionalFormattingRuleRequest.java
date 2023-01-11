// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateConditionalFormattingRuleRequest extends TeaModel {
    /**
     * <p>设定当前配置的规则的单元格样式</p>
     */
    @NameInMap("cellStyle")
    public CreateConditionalFormattingRuleRequestCellStyle cellStyle;

    /**
     * <p>重复值规则</p>
     */
    @NameInMap("duplicateCondition")
    public CreateConditionalFormattingRuleRequestDuplicateCondition duplicateCondition;

    /**
     * <p>条件格式生效的区域。</p>
     */
    @NameInMap("ranges")
    public java.util.List<String> ranges;

    /**
     * <p>操作人unionId</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static CreateConditionalFormattingRuleRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateConditionalFormattingRuleRequest self = new CreateConditionalFormattingRuleRequest();
        return TeaModel.build(map, self);
    }

    public CreateConditionalFormattingRuleRequest setCellStyle(CreateConditionalFormattingRuleRequestCellStyle cellStyle) {
        this.cellStyle = cellStyle;
        return this;
    }
    public CreateConditionalFormattingRuleRequestCellStyle getCellStyle() {
        return this.cellStyle;
    }

    public CreateConditionalFormattingRuleRequest setDuplicateCondition(CreateConditionalFormattingRuleRequestDuplicateCondition duplicateCondition) {
        this.duplicateCondition = duplicateCondition;
        return this;
    }
    public CreateConditionalFormattingRuleRequestDuplicateCondition getDuplicateCondition() {
        return this.duplicateCondition;
    }

    public CreateConditionalFormattingRuleRequest setRanges(java.util.List<String> ranges) {
        this.ranges = ranges;
        return this;
    }
    public java.util.List<String> getRanges() {
        return this.ranges;
    }

    public CreateConditionalFormattingRuleRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class CreateConditionalFormattingRuleRequestCellStyle extends TeaModel {
        /**
         * <p>背景色，使用十六进制颜色表示法，如#ff0000</p>
         */
        @NameInMap("backgroundColor")
        public String backgroundColor;

        public static CreateConditionalFormattingRuleRequestCellStyle build(java.util.Map<String, ?> map) throws Exception {
            CreateConditionalFormattingRuleRequestCellStyle self = new CreateConditionalFormattingRuleRequestCellStyle();
            return TeaModel.build(map, self);
        }

        public CreateConditionalFormattingRuleRequestCellStyle setBackgroundColor(String backgroundColor) {
            this.backgroundColor = backgroundColor;
            return this;
        }
        public String getBackgroundColor() {
            return this.backgroundColor;
        }

    }

    public static class CreateConditionalFormattingRuleRequestDuplicateCondition extends TeaModel {
        @NameInMap("operator")
        public String operator;

        public static CreateConditionalFormattingRuleRequestDuplicateCondition build(java.util.Map<String, ?> map) throws Exception {
            CreateConditionalFormattingRuleRequestDuplicateCondition self = new CreateConditionalFormattingRuleRequestDuplicateCondition();
            return TeaModel.build(map, self);
        }

        public CreateConditionalFormattingRuleRequestDuplicateCondition setOperator(String operator) {
            this.operator = operator;
            return this;
        }
        public String getOperator() {
            return this.operator;
        }

    }

}
