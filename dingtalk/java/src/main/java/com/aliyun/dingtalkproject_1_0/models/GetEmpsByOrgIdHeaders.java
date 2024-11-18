// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetEmpsByOrgIdHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("dingAccessTokenType")
    public String dingAccessTokenType;

    @NameInMap("dingIsvOrgId")
    public String dingIsvOrgId;

    @NameInMap("dingOrgId")
    public String dingOrgId;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static GetEmpsByOrgIdHeaders build(java.util.Map<String, ?> map) throws Exception {
        GetEmpsByOrgIdHeaders self = new GetEmpsByOrgIdHeaders();
        return TeaModel.build(map, self);
    }

    public GetEmpsByOrgIdHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public GetEmpsByOrgIdHeaders setDingAccessTokenType(String dingAccessTokenType) {
        this.dingAccessTokenType = dingAccessTokenType;
        return this;
    }
    public String getDingAccessTokenType() {
        return this.dingAccessTokenType;
    }

    public GetEmpsByOrgIdHeaders setDingIsvOrgId(String dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public String getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public GetEmpsByOrgIdHeaders setDingOrgId(String dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public String getDingOrgId() {
        return this.dingOrgId;
    }

    public GetEmpsByOrgIdHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
