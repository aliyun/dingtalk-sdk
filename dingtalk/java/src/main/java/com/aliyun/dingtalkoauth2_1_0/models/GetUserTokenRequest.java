// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetUserTokenRequest extends TeaModel {
    // 应用id
    @NameInMap("clientId")
    public String clientId;

    // 应用密码
    @NameInMap("clientSecret")
    public String clientSecret;

    // OAuth 2.0 临时授权码
    @NameInMap("code")
    public String code;

    // 分为authorization_code和refresh_token。使用授权码换token，传authorization_code；使用刷新token换用户token，传refresh_token
    @NameInMap("grantType")
    public String grantType;

    // OAuth 2.0 刷新令牌
    @NameInMap("refreshToken")
    public String refreshToken;

    public static GetUserTokenRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserTokenRequest self = new GetUserTokenRequest();
        return TeaModel.build(map, self);
    }

    public GetUserTokenRequest setClientId(String clientId) {
        this.clientId = clientId;
        return this;
    }
    public String getClientId() {
        return this.clientId;
    }

    public GetUserTokenRequest setClientSecret(String clientSecret) {
        this.clientSecret = clientSecret;
        return this;
    }
    public String getClientSecret() {
        return this.clientSecret;
    }

    public GetUserTokenRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetUserTokenRequest setGrantType(String grantType) {
        this.grantType = grantType;
        return this;
    }
    public String getGrantType() {
        return this.grantType;
    }

    public GetUserTokenRequest setRefreshToken(String refreshToken) {
        this.refreshToken = refreshToken;
        return this;
    }
    public String getRefreshToken() {
        return this.refreshToken;
    }

}
