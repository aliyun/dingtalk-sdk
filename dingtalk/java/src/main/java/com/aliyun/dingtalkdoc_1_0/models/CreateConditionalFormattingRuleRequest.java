// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateConditionalFormattingRuleRequest extends TeaModel {
    @NameInMap("cellStyle")
    public CreateConditionalFormattingRuleRequestCellStyle cellStyle;

    @NameInMap("duplicateCondition")
    public CreateConditionalFormattingRuleRequestDuplicateCondition duplicateCondition;

    @NameInMap("numberCondition")
    public CreateConditionalFormattingRuleRequestNumberCondition numberCondition;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("ranges")
    public java.util.List<String> ranges;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ppgAQuHfOoNVpJiStDwWCEgiEiE</p>
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

    public CreateConditionalFormattingRuleRequest setNumberCondition(CreateConditionalFormattingRuleRequestNumberCondition numberCondition) {
        this.numberCondition = numberCondition;
        return this;
    }
    public CreateConditionalFormattingRuleRequestNumberCondition getNumberCondition() {
        return this.numberCondition;
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
        @NameInMap("backgroundColor")
        public String backgroundColor;

        @NameInMap("fontColor")
        public String fontColor;

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

        public CreateConditionalFormattingRuleRequestCellStyle setFontColor(String fontColor) {
            this.fontColor = fontColor;
            return this;
        }
        public String getFontColor() {
            return this.fontColor;
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

    public static class CreateConditionalFormattingRuleRequestNumberCondition extends TeaModel {
        @NameInMap("operator")
        public String operator;

        @NameInMap("value1")
        public Object value1;

        @NameInMap("value2")
        public Object value2;

        public static CreateConditionalFormattingRuleRequestNumberCondition build(java.util.Map<String, ?> map) throws Exception {
            CreateConditionalFormattingRuleRequestNumberCondition self = new CreateConditionalFormattingRuleRequestNumberCondition();
            return TeaModel.build(map, self);
        }

        public CreateConditionalFormattingRuleRequestNumberCondition setOperator(String operator) {
            this.operator = operator;
            return this;
        }
        public String getOperator() {
            return this.operator;
        }

        public CreateConditionalFormattingRuleRequestNumberCondition setValue1(Object value1) {
            this.value1 = value1;
            return this;
        }
        public Object getValue1() {
            return this.value1;
        }

        public CreateConditionalFormattingRuleRequestNumberCondition setValue2(Object value2) {
            this.value2 = value2;
            return this;
        }
        public Object getValue2() {
            return this.value2;
        }

    }

}
