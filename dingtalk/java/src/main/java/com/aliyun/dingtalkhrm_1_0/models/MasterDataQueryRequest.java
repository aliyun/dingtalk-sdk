// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataQueryRequest extends TeaModel {
    @NameInMap("bizUK")
    public String bizUK;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public Integer nextToken;

    @NameInMap("optUserId")
    public String optUserId;

    @NameInMap("queryParams")
    public java.util.List<MasterDataQueryRequestQueryParams> queryParams;

    @NameInMap("relationIds")
    public java.util.List<String> relationIds;

    @NameInMap("scopeCode")
    public String scopeCode;

    @NameInMap("tenantId")
    public Long tenantId;

    @NameInMap("viewEntityCode")
    public String viewEntityCode;

    public static MasterDataQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        MasterDataQueryRequest self = new MasterDataQueryRequest();
        return TeaModel.build(map, self);
    }

    public MasterDataQueryRequest setBizUK(String bizUK) {
        this.bizUK = bizUK;
        return this;
    }
    public String getBizUK() {
        return this.bizUK;
    }

    public MasterDataQueryRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public MasterDataQueryRequest setNextToken(Integer nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Integer getNextToken() {
        return this.nextToken;
    }

    public MasterDataQueryRequest setOptUserId(String optUserId) {
        this.optUserId = optUserId;
        return this;
    }
    public String getOptUserId() {
        return this.optUserId;
    }

    public MasterDataQueryRequest setQueryParams(java.util.List<MasterDataQueryRequestQueryParams> queryParams) {
        this.queryParams = queryParams;
        return this;
    }
    public java.util.List<MasterDataQueryRequestQueryParams> getQueryParams() {
        return this.queryParams;
    }

    public MasterDataQueryRequest setRelationIds(java.util.List<String> relationIds) {
        this.relationIds = relationIds;
        return this;
    }
    public java.util.List<String> getRelationIds() {
        return this.relationIds;
    }

    public MasterDataQueryRequest setScopeCode(String scopeCode) {
        this.scopeCode = scopeCode;
        return this;
    }
    public String getScopeCode() {
        return this.scopeCode;
    }

    public MasterDataQueryRequest setTenantId(Long tenantId) {
        this.tenantId = tenantId;
        return this;
    }
    public Long getTenantId() {
        return this.tenantId;
    }

    public MasterDataQueryRequest setViewEntityCode(String viewEntityCode) {
        this.viewEntityCode = viewEntityCode;
        return this;
    }
    public String getViewEntityCode() {
        return this.viewEntityCode;
    }

    public static class MasterDataQueryRequestQueryParamsConditionList extends TeaModel {
        @NameInMap("operate")
        public String operate;

        @NameInMap("value")
        public String value;

        public static MasterDataQueryRequestQueryParamsConditionList build(java.util.Map<String, ?> map) throws Exception {
            MasterDataQueryRequestQueryParamsConditionList self = new MasterDataQueryRequestQueryParamsConditionList();
            return TeaModel.build(map, self);
        }

        public MasterDataQueryRequestQueryParamsConditionList setOperate(String operate) {
            this.operate = operate;
            return this;
        }
        public String getOperate() {
            return this.operate;
        }

        public MasterDataQueryRequestQueryParamsConditionList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class MasterDataQueryRequestQueryParams extends TeaModel {
        @NameInMap("conditionList")
        public java.util.List<MasterDataQueryRequestQueryParamsConditionList> conditionList;

        @NameInMap("fieldCode")
        public String fieldCode;

        @NameInMap("joinType")
        public String joinType;

        public static MasterDataQueryRequestQueryParams build(java.util.Map<String, ?> map) throws Exception {
            MasterDataQueryRequestQueryParams self = new MasterDataQueryRequestQueryParams();
            return TeaModel.build(map, self);
        }

        public MasterDataQueryRequestQueryParams setConditionList(java.util.List<MasterDataQueryRequestQueryParamsConditionList> conditionList) {
            this.conditionList = conditionList;
            return this;
        }
        public java.util.List<MasterDataQueryRequestQueryParamsConditionList> getConditionList() {
            return this.conditionList;
        }

        public MasterDataQueryRequestQueryParams setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public MasterDataQueryRequestQueryParams setJoinType(String joinType) {
            this.joinType = joinType;
            return this;
        }
        public String getJoinType() {
            return this.joinType;
        }

    }

}
