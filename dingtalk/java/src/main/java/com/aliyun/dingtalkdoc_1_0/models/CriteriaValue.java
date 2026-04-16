// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CriteriaValue extends TeaModel {
    @NameInMap("filterType")
    public String filterType;

    @NameInMap("visibleValues")
    public java.util.List<String> visibleValues;

    @NameInMap("conditions")
    public java.util.List<CriteriaValueConditions> conditions;

    @NameInMap("conditionOperator")
    public String conditionOperator;

    @NameInMap("backgroundColor")
    public String backgroundColor;

    @NameInMap("fontColor")
    public String fontColor;

    public static CriteriaValue build(java.util.Map<String, ?> map) throws Exception {
        CriteriaValue self = new CriteriaValue();
        return TeaModel.build(map, self);
    }

    public CriteriaValue setFilterType(String filterType) {
        this.filterType = filterType;
        return this;
    }
    public String getFilterType() {
        return this.filterType;
    }

    public CriteriaValue setVisibleValues(java.util.List<String> visibleValues) {
        this.visibleValues = visibleValues;
        return this;
    }
    public java.util.List<String> getVisibleValues() {
        return this.visibleValues;
    }

    public CriteriaValue setConditions(java.util.List<CriteriaValueConditions> conditions) {
        this.conditions = conditions;
        return this;
    }
    public java.util.List<CriteriaValueConditions> getConditions() {
        return this.conditions;
    }

    public CriteriaValue setConditionOperator(String conditionOperator) {
        this.conditionOperator = conditionOperator;
        return this;
    }
    public String getConditionOperator() {
        return this.conditionOperator;
    }

    public CriteriaValue setBackgroundColor(String backgroundColor) {
        this.backgroundColor = backgroundColor;
        return this;
    }
    public String getBackgroundColor() {
        return this.backgroundColor;
    }

    public CriteriaValue setFontColor(String fontColor) {
        this.fontColor = fontColor;
        return this;
    }
    public String getFontColor() {
        return this.fontColor;
    }

    public static class CriteriaValueConditions extends TeaModel {
        @NameInMap("operator")
        public String operator;

        @NameInMap("value")
        public String value;

        public static CriteriaValueConditions build(java.util.Map<String, ?> map) throws Exception {
            CriteriaValueConditions self = new CriteriaValueConditions();
            return TeaModel.build(map, self);
        }

        public CriteriaValueConditions setOperator(String operator) {
            this.operator = operator;
            return this;
        }
        public String getOperator() {
            return this.operator;
        }

        public CriteriaValueConditions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
