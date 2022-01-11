// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetTbProjectSourceHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("dingAccessTokenType")
    public String dingAccessTokenType;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("dingIsvOrgId")
    public String dingIsvOrgId;

    @NameInMap("dingOrgId")
    public String dingOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static GetTbProjectSourceHeaders build(java.util.Map<String, ?> map) throws Exception {
        GetTbProjectSourceHeaders self = new GetTbProjectSourceHeaders();
        return TeaModel.build(map, self);
    }

    public GetTbProjectSourceHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public GetTbProjectSourceHeaders setDingAccessTokenType(String dingAccessTokenType) {
        this.dingAccessTokenType = dingAccessTokenType;
        return this;
    }
    public String getDingAccessTokenType() {
        return this.dingAccessTokenType;
    }

    public GetTbProjectSourceHeaders setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public GetTbProjectSourceHeaders setDingIsvOrgId(String dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public String getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public GetTbProjectSourceHeaders setDingOrgId(String dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public String getDingOrgId() {
        return this.dingOrgId;
    }

    public GetTbProjectSourceHeaders setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public GetTbProjectSourceHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
