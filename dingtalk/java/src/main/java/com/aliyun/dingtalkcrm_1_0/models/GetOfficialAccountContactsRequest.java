// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountContactsRequest extends TeaModel {
    @NameInMap("context")
    public GetOfficialAccountContactsRequestContext context;

    // 取数游标，第一次传0
    @NameInMap("nextToken")
    public String nextToken;

    // 分页大小，最大不超过10
    @NameInMap("maxResults")
    public Long maxResults;

    public static GetOfficialAccountContactsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountContactsRequest self = new GetOfficialAccountContactsRequest();
        return TeaModel.build(map, self);
    }

    public GetOfficialAccountContactsRequest setContext(GetOfficialAccountContactsRequestContext context) {
        this.context = context;
        return this;
    }
    public GetOfficialAccountContactsRequestContext getContext() {
        return this.context;
    }

    public GetOfficialAccountContactsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetOfficialAccountContactsRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public static class GetOfficialAccountContactsRequestContext extends TeaModel {
        @NameInMap("dingIsvOrgId")
        public Long dingIsvOrgId;

        @NameInMap("dingOrgId")
        public Long dingOrgId;

        @NameInMap("dingSuiteKey")
        public String dingSuiteKey;

        @NameInMap("dingCorpId")
        public String dingCorpId;

        @NameInMap("dingTokenGrantType")
        public Long dingTokenGrantType;

        public static GetOfficialAccountContactsRequestContext build(java.util.Map<String, ?> map) throws Exception {
            GetOfficialAccountContactsRequestContext self = new GetOfficialAccountContactsRequestContext();
            return TeaModel.build(map, self);
        }

        public GetOfficialAccountContactsRequestContext setDingIsvOrgId(Long dingIsvOrgId) {
            this.dingIsvOrgId = dingIsvOrgId;
            return this;
        }
        public Long getDingIsvOrgId() {
            return this.dingIsvOrgId;
        }

        public GetOfficialAccountContactsRequestContext setDingOrgId(Long dingOrgId) {
            this.dingOrgId = dingOrgId;
            return this;
        }
        public Long getDingOrgId() {
            return this.dingOrgId;
        }

        public GetOfficialAccountContactsRequestContext setDingSuiteKey(String dingSuiteKey) {
            this.dingSuiteKey = dingSuiteKey;
            return this;
        }
        public String getDingSuiteKey() {
            return this.dingSuiteKey;
        }

        public GetOfficialAccountContactsRequestContext setDingCorpId(String dingCorpId) {
            this.dingCorpId = dingCorpId;
            return this;
        }
        public String getDingCorpId() {
            return this.dingCorpId;
        }

        public GetOfficialAccountContactsRequestContext setDingTokenGrantType(Long dingTokenGrantType) {
            this.dingTokenGrantType = dingTokenGrantType;
            return this;
        }
        public Long getDingTokenGrantType() {
            return this.dingTokenGrantType;
        }

    }

}
