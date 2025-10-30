// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class ListRecordsRequest extends TeaModel {
    @NameInMap("calcFields")
    public Boolean calcFields;

    @NameInMap("filter")
    public ListRecordsRequestFilter filter;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static ListRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListRecordsRequest self = new ListRecordsRequest();
        return TeaModel.build(map, self);
    }

    public ListRecordsRequest setCalcFields(Boolean calcFields) {
        this.calcFields = calcFields;
        return this;
    }
    public Boolean getCalcFields() {
        return this.calcFields;
    }

    public ListRecordsRequest setFilter(ListRecordsRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public ListRecordsRequestFilter getFilter() {
        return this.filter;
    }

    public ListRecordsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListRecordsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListRecordsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class ListRecordsRequestFilterConditions extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("field")
        public String field;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("operator")
        public String operator;

        @NameInMap("value")
        public java.util.List<?> value;

        public static ListRecordsRequestFilterConditions build(java.util.Map<String, ?> map) throws Exception {
            ListRecordsRequestFilterConditions self = new ListRecordsRequestFilterConditions();
            return TeaModel.build(map, self);
        }

        public ListRecordsRequestFilterConditions setField(String field) {
            this.field = field;
            return this;
        }
        public String getField() {
            return this.field;
        }

        public ListRecordsRequestFilterConditions setOperator(String operator) {
            this.operator = operator;
            return this;
        }
        public String getOperator() {
            return this.operator;
        }

        public ListRecordsRequestFilterConditions setValue(java.util.List<?> value) {
            this.value = value;
            return this;
        }
        public java.util.List<?> getValue() {
            return this.value;
        }

    }

    public static class ListRecordsRequestFilter extends TeaModel {
        @NameInMap("combination")
        public String combination;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("conditions")
        public java.util.List<ListRecordsRequestFilterConditions> conditions;

        public static ListRecordsRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            ListRecordsRequestFilter self = new ListRecordsRequestFilter();
            return TeaModel.build(map, self);
        }

        public ListRecordsRequestFilter setCombination(String combination) {
            this.combination = combination;
            return this;
        }
        public String getCombination() {
            return this.combination;
        }

        public ListRecordsRequestFilter setConditions(java.util.List<ListRecordsRequestFilterConditions> conditions) {
            this.conditions = conditions;
            return this;
        }
        public java.util.List<ListRecordsRequestFilterConditions> getConditions() {
            return this.conditions;
        }

    }

}
