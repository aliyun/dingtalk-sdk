// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDatasQueryRequest extends TeaModel {
    @NameInMap("bizUK")
    public String bizUK;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nextToken")
    public Integer nextToken;

    @NameInMap("queryParams")
    public java.util.List<MasterDatasQueryRequestQueryParams> queryParams;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("relationIds")
    public java.util.List<String> relationIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("scopeCode")
    public String scopeCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tenantId")
    public Long tenantId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("viewEntityCode")
    public String viewEntityCode;

    public static MasterDatasQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        MasterDatasQueryRequest self = new MasterDatasQueryRequest();
        return TeaModel.build(map, self);
    }

    public MasterDatasQueryRequest setBizUK(String bizUK) {
        this.bizUK = bizUK;
        return this;
    }
    public String getBizUK() {
        return this.bizUK;
    }

    public MasterDatasQueryRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public MasterDatasQueryRequest setNextToken(Integer nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Integer getNextToken() {
        return this.nextToken;
    }

    public MasterDatasQueryRequest setQueryParams(java.util.List<MasterDatasQueryRequestQueryParams> queryParams) {
        this.queryParams = queryParams;
        return this;
    }
    public java.util.List<MasterDatasQueryRequestQueryParams> getQueryParams() {
        return this.queryParams;
    }

    public MasterDatasQueryRequest setRelationIds(java.util.List<String> relationIds) {
        this.relationIds = relationIds;
        return this;
    }
    public java.util.List<String> getRelationIds() {
        return this.relationIds;
    }

    public MasterDatasQueryRequest setScopeCode(String scopeCode) {
        this.scopeCode = scopeCode;
        return this;
    }
    public String getScopeCode() {
        return this.scopeCode;
    }

    public MasterDatasQueryRequest setTenantId(Long tenantId) {
        this.tenantId = tenantId;
        return this;
    }
    public Long getTenantId() {
        return this.tenantId;
    }

    public MasterDatasQueryRequest setViewEntityCode(String viewEntityCode) {
        this.viewEntityCode = viewEntityCode;
        return this;
    }
    public String getViewEntityCode() {
        return this.viewEntityCode;
    }

    public static class MasterDatasQueryRequestQueryParamsConditionList extends TeaModel {
        @NameInMap("operate")
        public String operate;

        @NameInMap("value")
        public String value;

        public static MasterDatasQueryRequestQueryParamsConditionList build(java.util.Map<String, ?> map) throws Exception {
            MasterDatasQueryRequestQueryParamsConditionList self = new MasterDatasQueryRequestQueryParamsConditionList();
            return TeaModel.build(map, self);
        }

        public MasterDatasQueryRequestQueryParamsConditionList setOperate(String operate) {
            this.operate = operate;
            return this;
        }
        public String getOperate() {
            return this.operate;
        }

        public MasterDatasQueryRequestQueryParamsConditionList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class MasterDatasQueryRequestQueryParams extends TeaModel {
        @NameInMap("conditionList")
        public java.util.List<MasterDatasQueryRequestQueryParamsConditionList> conditionList;

        @NameInMap("fieldCode")
        public String fieldCode;

        @NameInMap("joinType")
        public String joinType;

        public static MasterDatasQueryRequestQueryParams build(java.util.Map<String, ?> map) throws Exception {
            MasterDatasQueryRequestQueryParams self = new MasterDatasQueryRequestQueryParams();
            return TeaModel.build(map, self);
        }

        public MasterDatasQueryRequestQueryParams setConditionList(java.util.List<MasterDatasQueryRequestQueryParamsConditionList> conditionList) {
            this.conditionList = conditionList;
            return this;
        }
        public java.util.List<MasterDatasQueryRequestQueryParamsConditionList> getConditionList() {
            return this.conditionList;
        }

        public MasterDatasQueryRequestQueryParams setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public MasterDatasQueryRequestQueryParams setJoinType(String joinType) {
            this.joinType = joinType;
            return this;
        }
        public String getJoinType() {
            return this.joinType;
        }

    }

}
