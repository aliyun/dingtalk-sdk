// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataQueryRequest extends TeaModel {
    // 领域code 由钉钉分配
    @NameInMap("scopeCode")
    public String scopeCode;

    // 实体code
    @NameInMap("viewEntityCode")
    public String viewEntityCode;

    // 数据生产方的租户id，由钉钉分配
    @NameInMap("tenantId")
    public Long tenantId;

    // 数据唯一键
    @NameInMap("bizUK")
    public String bizUK;

    // 关联id列表，一般为userId
    @NameInMap("relationIds")
    public java.util.List<String> relationIds;

    // 当前操作人userId
    @NameInMap("optUserId")
    public String optUserId;

    // 分页查询的游标
    @NameInMap("nextToken")
    public Integer nextToken;

    // 分页查询每页数据条数
    @NameInMap("maxResults")
    public Integer maxResults;

    // 其他查询条件
    @NameInMap("queryParams")
    public java.util.List<MasterDataQueryRequestQueryParams> queryParams;

    public static MasterDataQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        MasterDataQueryRequest self = new MasterDataQueryRequest();
        return TeaModel.build(map, self);
    }

    public MasterDataQueryRequest setScopeCode(String scopeCode) {
        this.scopeCode = scopeCode;
        return this;
    }
    public String getScopeCode() {
        return this.scopeCode;
    }

    public MasterDataQueryRequest setViewEntityCode(String viewEntityCode) {
        this.viewEntityCode = viewEntityCode;
        return this;
    }
    public String getViewEntityCode() {
        return this.viewEntityCode;
    }

    public MasterDataQueryRequest setTenantId(Long tenantId) {
        this.tenantId = tenantId;
        return this;
    }
    public Long getTenantId() {
        return this.tenantId;
    }

    public MasterDataQueryRequest setBizUK(String bizUK) {
        this.bizUK = bizUK;
        return this;
    }
    public String getBizUK() {
        return this.bizUK;
    }

    public MasterDataQueryRequest setRelationIds(java.util.List<String> relationIds) {
        this.relationIds = relationIds;
        return this;
    }
    public java.util.List<String> getRelationIds() {
        return this.relationIds;
    }

    public MasterDataQueryRequest setOptUserId(String optUserId) {
        this.optUserId = optUserId;
        return this;
    }
    public String getOptUserId() {
        return this.optUserId;
    }

    public MasterDataQueryRequest setNextToken(Integer nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Integer getNextToken() {
        return this.nextToken;
    }

    public MasterDataQueryRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public MasterDataQueryRequest setQueryParams(java.util.List<MasterDataQueryRequestQueryParams> queryParams) {
        this.queryParams = queryParams;
        return this;
    }
    public java.util.List<MasterDataQueryRequestQueryParams> getQueryParams() {
        return this.queryParams;
    }

    public static class MasterDataQueryRequestQueryParamsConditionList extends TeaModel {
        // 字段关系符
        @NameInMap("operate")
        public String operate;

        // 操作值
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
        // 需要筛选的字段
        @NameInMap("fieldCode")
        public String fieldCode;

        // 筛选条件连接类型
        @NameInMap("joinType")
        public String joinType;

        // 筛选条件
        @NameInMap("conditionList")
        public java.util.List<MasterDataQueryRequestQueryParamsConditionList> conditionList;

        public static MasterDataQueryRequestQueryParams build(java.util.Map<String, ?> map) throws Exception {
            MasterDataQueryRequestQueryParams self = new MasterDataQueryRequestQueryParams();
            return TeaModel.build(map, self);
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

        public MasterDataQueryRequestQueryParams setConditionList(java.util.List<MasterDataQueryRequestQueryParamsConditionList> conditionList) {
            this.conditionList = conditionList;
            return this;
        }
        public java.util.List<MasterDataQueryRequestQueryParamsConditionList> getConditionList() {
            return this.conditionList;
        }

    }

}
