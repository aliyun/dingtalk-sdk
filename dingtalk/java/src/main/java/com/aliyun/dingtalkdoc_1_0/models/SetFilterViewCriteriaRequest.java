// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetFilterViewCriteriaRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("column")
    public Long column;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("filterCriteria")
    public SetFilterViewCriteriaRequestFilterCriteria filterCriteria;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static SetFilterViewCriteriaRequest build(java.util.Map<String, ?> map) throws Exception {
        SetFilterViewCriteriaRequest self = new SetFilterViewCriteriaRequest();
        return TeaModel.build(map, self);
    }

    public SetFilterViewCriteriaRequest setColumn(Long column) {
        this.column = column;
        return this;
    }
    public Long getColumn() {
        return this.column;
    }

    public SetFilterViewCriteriaRequest setFilterCriteria(SetFilterViewCriteriaRequestFilterCriteria filterCriteria) {
        this.filterCriteria = filterCriteria;
        return this;
    }
    public SetFilterViewCriteriaRequestFilterCriteria getFilterCriteria() {
        return this.filterCriteria;
    }

    public SetFilterViewCriteriaRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class SetFilterViewCriteriaRequestFilterCriteriaConditions extends TeaModel {
        @NameInMap("operator")
        public String operator;

        @NameInMap("value")
        public String value;

        public static SetFilterViewCriteriaRequestFilterCriteriaConditions build(java.util.Map<String, ?> map) throws Exception {
            SetFilterViewCriteriaRequestFilterCriteriaConditions self = new SetFilterViewCriteriaRequestFilterCriteriaConditions();
            return TeaModel.build(map, self);
        }

        public SetFilterViewCriteriaRequestFilterCriteriaConditions setOperator(String operator) {
            this.operator = operator;
            return this;
        }
        public String getOperator() {
            return this.operator;
        }

        public SetFilterViewCriteriaRequestFilterCriteriaConditions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class SetFilterViewCriteriaRequestFilterCriteria extends TeaModel {
        @NameInMap("backgroundColor")
        public String backgroundColor;

        @NameInMap("conditionOperator")
        public String conditionOperator;

        @NameInMap("conditions")
        public java.util.List<SetFilterViewCriteriaRequestFilterCriteriaConditions> conditions;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("filterType")
        public String filterType;

        @NameInMap("fontColor")
        public String fontColor;

        @NameInMap("visibleValues")
        public java.util.List<String> visibleValues;

        public static SetFilterViewCriteriaRequestFilterCriteria build(java.util.Map<String, ?> map) throws Exception {
            SetFilterViewCriteriaRequestFilterCriteria self = new SetFilterViewCriteriaRequestFilterCriteria();
            return TeaModel.build(map, self);
        }

        public SetFilterViewCriteriaRequestFilterCriteria setBackgroundColor(String backgroundColor) {
            this.backgroundColor = backgroundColor;
            return this;
        }
        public String getBackgroundColor() {
            return this.backgroundColor;
        }

        public SetFilterViewCriteriaRequestFilterCriteria setConditionOperator(String conditionOperator) {
            this.conditionOperator = conditionOperator;
            return this;
        }
        public String getConditionOperator() {
            return this.conditionOperator;
        }

        public SetFilterViewCriteriaRequestFilterCriteria setConditions(java.util.List<SetFilterViewCriteriaRequestFilterCriteriaConditions> conditions) {
            this.conditions = conditions;
            return this;
        }
        public java.util.List<SetFilterViewCriteriaRequestFilterCriteriaConditions> getConditions() {
            return this.conditions;
        }

        public SetFilterViewCriteriaRequestFilterCriteria setFilterType(String filterType) {
            this.filterType = filterType;
            return this;
        }
        public String getFilterType() {
            return this.filterType;
        }

        public SetFilterViewCriteriaRequestFilterCriteria setFontColor(String fontColor) {
            this.fontColor = fontColor;
            return this;
        }
        public String getFontColor() {
            return this.fontColor;
        }

        public SetFilterViewCriteriaRequestFilterCriteria setVisibleValues(java.util.List<String> visibleValues) {
            this.visibleValues = visibleValues;
            return this;
        }
        public java.util.List<String> getVisibleValues() {
            return this.visibleValues;
        }

    }

}
