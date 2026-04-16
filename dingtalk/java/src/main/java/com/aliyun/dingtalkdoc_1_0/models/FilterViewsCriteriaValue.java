// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class FilterViewsCriteriaValue extends TeaModel {
    @NameInMap("filterType")
    public String filterType;

    @NameInMap("visibleValues")
    public java.util.List<String> visibleValues;

    @NameInMap("conditions")
    public java.util.List<FilterViewsCriteriaValueConditions> conditions;

    @NameInMap("conditionOperator")
    public String conditionOperator;

    @NameInMap("backgroundColor")
    public String backgroundColor;

    @NameInMap("fontColor")
    public String fontColor;

    public static FilterViewsCriteriaValue build(java.util.Map<String, ?> map) throws Exception {
        FilterViewsCriteriaValue self = new FilterViewsCriteriaValue();
        return TeaModel.build(map, self);
    }

    public FilterViewsCriteriaValue setFilterType(String filterType) {
        this.filterType = filterType;
        return this;
    }
    public String getFilterType() {
        return this.filterType;
    }

    public FilterViewsCriteriaValue setVisibleValues(java.util.List<String> visibleValues) {
        this.visibleValues = visibleValues;
        return this;
    }
    public java.util.List<String> getVisibleValues() {
        return this.visibleValues;
    }

    public FilterViewsCriteriaValue setConditions(java.util.List<FilterViewsCriteriaValueConditions> conditions) {
        this.conditions = conditions;
        return this;
    }
    public java.util.List<FilterViewsCriteriaValueConditions> getConditions() {
        return this.conditions;
    }

    public FilterViewsCriteriaValue setConditionOperator(String conditionOperator) {
        this.conditionOperator = conditionOperator;
        return this;
    }
    public String getConditionOperator() {
        return this.conditionOperator;
    }

    public FilterViewsCriteriaValue setBackgroundColor(String backgroundColor) {
        this.backgroundColor = backgroundColor;
        return this;
    }
    public String getBackgroundColor() {
        return this.backgroundColor;
    }

    public FilterViewsCriteriaValue setFontColor(String fontColor) {
        this.fontColor = fontColor;
        return this;
    }
    public String getFontColor() {
        return this.fontColor;
    }

    public static class FilterViewsCriteriaValueConditions extends TeaModel {
        @NameInMap("operator")
        public String operator;

        @NameInMap("value")
        public String value;

        public static FilterViewsCriteriaValueConditions build(java.util.Map<String, ?> map) throws Exception {
            FilterViewsCriteriaValueConditions self = new FilterViewsCriteriaValueConditions();
            return TeaModel.build(map, self);
        }

        public FilterViewsCriteriaValueConditions setOperator(String operator) {
            this.operator = operator;
            return this;
        }
        public String getOperator() {
            return this.operator;
        }

        public FilterViewsCriteriaValueConditions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
