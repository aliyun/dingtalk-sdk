// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataQueryRequest extends TeaModel {
    @NameInMap("body")
    public MasterDataQueryRequestBody body;

    public static MasterDataQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        MasterDataQueryRequest self = new MasterDataQueryRequest();
        return TeaModel.build(map, self);
    }

    public MasterDataQueryRequest setBody(MasterDataQueryRequestBody body) {
        this.body = body;
        return this;
    }
    public MasterDataQueryRequestBody getBody() {
        return this.body;
    }

    public static class MasterDataQueryRequestBody extends TeaModel {
        @NameInMap("scopeCode")
        public String scopeCode;

        @NameInMap("viewEntityCode")
        public String viewEntityCode;

        @NameInMap("tenantId")
        public Long tenantId;

        @NameInMap("bizUK")
        public String bizUK;

        @NameInMap("relationIds")
        public java.util.List<String> relationIds;

        @NameInMap("optUserId")
        public String optUserId;

        @NameInMap("nextToken")
        public Integer nextToken;

        @NameInMap("maxResults")
        public Integer maxResults;

        public static MasterDataQueryRequestBody build(java.util.Map<String, ?> map) throws Exception {
            MasterDataQueryRequestBody self = new MasterDataQueryRequestBody();
            return TeaModel.build(map, self);
        }

        public MasterDataQueryRequestBody setScopeCode(String scopeCode) {
            this.scopeCode = scopeCode;
            return this;
        }
        public String getScopeCode() {
            return this.scopeCode;
        }

        public MasterDataQueryRequestBody setViewEntityCode(String viewEntityCode) {
            this.viewEntityCode = viewEntityCode;
            return this;
        }
        public String getViewEntityCode() {
            return this.viewEntityCode;
        }

        public MasterDataQueryRequestBody setTenantId(Long tenantId) {
            this.tenantId = tenantId;
            return this;
        }
        public Long getTenantId() {
            return this.tenantId;
        }

        public MasterDataQueryRequestBody setBizUK(String bizUK) {
            this.bizUK = bizUK;
            return this;
        }
        public String getBizUK() {
            return this.bizUK;
        }

        public MasterDataQueryRequestBody setRelationIds(java.util.List<String> relationIds) {
            this.relationIds = relationIds;
            return this;
        }
        public java.util.List<String> getRelationIds() {
            return this.relationIds;
        }

        public MasterDataQueryRequestBody setOptUserId(String optUserId) {
            this.optUserId = optUserId;
            return this;
        }
        public String getOptUserId() {
            return this.optUserId;
        }

        public MasterDataQueryRequestBody setNextToken(Integer nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public Integer getNextToken() {
            return this.nextToken;
        }

        public MasterDataQueryRequestBody setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

    }

}
