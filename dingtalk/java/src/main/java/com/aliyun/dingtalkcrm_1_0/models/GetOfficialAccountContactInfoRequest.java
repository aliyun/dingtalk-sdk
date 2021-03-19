// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountContactInfoRequest extends TeaModel {
    @NameInMap("context")
    public GetOfficialAccountContactInfoRequestContext context;

    public static GetOfficialAccountContactInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountContactInfoRequest self = new GetOfficialAccountContactInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetOfficialAccountContactInfoRequest setContext(GetOfficialAccountContactInfoRequestContext context) {
        this.context = context;
        return this;
    }
    public GetOfficialAccountContactInfoRequestContext getContext() {
        return this.context;
    }

    public static class GetOfficialAccountContactInfoRequestContext extends TeaModel {
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

        @NameInMap("dingClientId")
        public String dingClientId;

        @NameInMap("dingOauthAppId")
        public Long dingOauthAppId;

        public static GetOfficialAccountContactInfoRequestContext build(java.util.Map<String, ?> map) throws Exception {
            GetOfficialAccountContactInfoRequestContext self = new GetOfficialAccountContactInfoRequestContext();
            return TeaModel.build(map, self);
        }

        public GetOfficialAccountContactInfoRequestContext setDingIsvOrgId(Long dingIsvOrgId) {
            this.dingIsvOrgId = dingIsvOrgId;
            return this;
        }
        public Long getDingIsvOrgId() {
            return this.dingIsvOrgId;
        }

        public GetOfficialAccountContactInfoRequestContext setDingOrgId(Long dingOrgId) {
            this.dingOrgId = dingOrgId;
            return this;
        }
        public Long getDingOrgId() {
            return this.dingOrgId;
        }

        public GetOfficialAccountContactInfoRequestContext setDingSuiteKey(String dingSuiteKey) {
            this.dingSuiteKey = dingSuiteKey;
            return this;
        }
        public String getDingSuiteKey() {
            return this.dingSuiteKey;
        }

        public GetOfficialAccountContactInfoRequestContext setDingCorpId(String dingCorpId) {
            this.dingCorpId = dingCorpId;
            return this;
        }
        public String getDingCorpId() {
            return this.dingCorpId;
        }

        public GetOfficialAccountContactInfoRequestContext setDingTokenGrantType(Long dingTokenGrantType) {
            this.dingTokenGrantType = dingTokenGrantType;
            return this;
        }
        public Long getDingTokenGrantType() {
            return this.dingTokenGrantType;
        }

        public GetOfficialAccountContactInfoRequestContext setDingClientId(String dingClientId) {
            this.dingClientId = dingClientId;
            return this;
        }
        public String getDingClientId() {
            return this.dingClientId;
        }

        public GetOfficialAccountContactInfoRequestContext setDingOauthAppId(Long dingOauthAppId) {
            this.dingOauthAppId = dingOauthAppId;
            return this;
        }
        public Long getDingOauthAppId() {
            return this.dingOauthAppId;
        }

    }

}
