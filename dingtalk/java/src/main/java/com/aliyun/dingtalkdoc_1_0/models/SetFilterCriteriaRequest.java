// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetFilterCriteriaRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("column")
    public Long column;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("filterCriteria")
    public SetFilterCriteriaRequestFilterCriteria filterCriteria;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static SetFilterCriteriaRequest build(java.util.Map<String, ?> map) throws Exception {
        SetFilterCriteriaRequest self = new SetFilterCriteriaRequest();
        return TeaModel.build(map, self);
    }

    public SetFilterCriteriaRequest setColumn(Long column) {
        this.column = column;
        return this;
    }
    public Long getColumn() {
        return this.column;
    }

    public SetFilterCriteriaRequest setFilterCriteria(SetFilterCriteriaRequestFilterCriteria filterCriteria) {
        this.filterCriteria = filterCriteria;
        return this;
    }
    public SetFilterCriteriaRequestFilterCriteria getFilterCriteria() {
        return this.filterCriteria;
    }

    public SetFilterCriteriaRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class SetFilterCriteriaRequestFilterCriteriaConditions extends TeaModel {
        @NameInMap("operator")
        public String operator;

        @NameInMap("value")
        public String value;

        public static SetFilterCriteriaRequestFilterCriteriaConditions build(java.util.Map<String, ?> map) throws Exception {
            SetFilterCriteriaRequestFilterCriteriaConditions self = new SetFilterCriteriaRequestFilterCriteriaConditions();
            return TeaModel.build(map, self);
        }

        public SetFilterCriteriaRequestFilterCriteriaConditions setOperator(String operator) {
            this.operator = operator;
            return this;
        }
        public String getOperator() {
            return this.operator;
        }

        public SetFilterCriteriaRequestFilterCriteriaConditions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class SetFilterCriteriaRequestFilterCriteria extends TeaModel {
        @NameInMap("backgroundColor")
        public String backgroundColor;

        @NameInMap("conditionOperator")
        public String conditionOperator;

        @NameInMap("conditions")
        public java.util.List<SetFilterCriteriaRequestFilterCriteriaConditions> conditions;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("filterType")
        public String filterType;

        @NameInMap("fontColor")
        public String fontColor;

        @NameInMap("visibleValues")
        public java.util.List<String> visibleValues;

        public static SetFilterCriteriaRequestFilterCriteria build(java.util.Map<String, ?> map) throws Exception {
            SetFilterCriteriaRequestFilterCriteria self = new SetFilterCriteriaRequestFilterCriteria();
            return TeaModel.build(map, self);
        }

        public SetFilterCriteriaRequestFilterCriteria setBackgroundColor(String backgroundColor) {
            this.backgroundColor = backgroundColor;
            return this;
        }
        public String getBackgroundColor() {
            return this.backgroundColor;
        }

        public SetFilterCriteriaRequestFilterCriteria setConditionOperator(String conditionOperator) {
            this.conditionOperator = conditionOperator;
            return this;
        }
        public String getConditionOperator() {
            return this.conditionOperator;
        }

        public SetFilterCriteriaRequestFilterCriteria setConditions(java.util.List<SetFilterCriteriaRequestFilterCriteriaConditions> conditions) {
            this.conditions = conditions;
            return this;
        }
        public java.util.List<SetFilterCriteriaRequestFilterCriteriaConditions> getConditions() {
            return this.conditions;
        }

        public SetFilterCriteriaRequestFilterCriteria setFilterType(String filterType) {
            this.filterType = filterType;
            return this;
        }
        public String getFilterType() {
            return this.filterType;
        }

        public SetFilterCriteriaRequestFilterCriteria setFontColor(String fontColor) {
            this.fontColor = fontColor;
            return this;
        }
        public String getFontColor() {
            return this.fontColor;
        }

        public SetFilterCriteriaRequestFilterCriteria setVisibleValues(java.util.List<String> visibleValues) {
            this.visibleValues = visibleValues;
            return this;
        }
        public java.util.List<String> getVisibleValues() {
            return this.visibleValues;
        }

    }

}
