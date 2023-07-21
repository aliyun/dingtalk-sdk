// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetYongYouOpenApiTokenResponseBody extends TeaModel {
    @NameInMap("accessToken")
    public String accessToken;

    @NameInMap("appName")
    public String appName;

    @NameInMap("expiresIn")
    public String expiresIn;

    @NameInMap("refreshExpiresIn")
    public String refreshExpiresIn;

    @NameInMap("refreshToken")
    public String refreshToken;

    @NameInMap("scope")
    public String scope;

    @NameInMap("sid")
    public String sid;

    @NameInMap("yongyouOrgId")
    public String yongyouOrgId;

    @NameInMap("yongyouUserId")
    public String yongyouUserId;

    public static GetYongYouOpenApiTokenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetYongYouOpenApiTokenResponseBody self = new GetYongYouOpenApiTokenResponseBody();
        return TeaModel.build(map, self);
    }

    public GetYongYouOpenApiTokenResponseBody setAccessToken(String accessToken) {
        this.accessToken = accessToken;
        return this;
    }
    public String getAccessToken() {
        return this.accessToken;
    }

    public GetYongYouOpenApiTokenResponseBody setAppName(String appName) {
        this.appName = appName;
        return this;
    }
    public String getAppName() {
        return this.appName;
    }

    public GetYongYouOpenApiTokenResponseBody setExpiresIn(String expiresIn) {
        this.expiresIn = expiresIn;
        return this;
    }
    public String getExpiresIn() {
        return this.expiresIn;
    }

    public GetYongYouOpenApiTokenResponseBody setRefreshExpiresIn(String refreshExpiresIn) {
        this.refreshExpiresIn = refreshExpiresIn;
        return this;
    }
    public String getRefreshExpiresIn() {
        return this.refreshExpiresIn;
    }

    public GetYongYouOpenApiTokenResponseBody setRefreshToken(String refreshToken) {
        this.refreshToken = refreshToken;
        return this;
    }
    public String getRefreshToken() {
        return this.refreshToken;
    }

    public GetYongYouOpenApiTokenResponseBody setScope(String scope) {
        this.scope = scope;
        return this;
    }
    public String getScope() {
        return this.scope;
    }

    public GetYongYouOpenApiTokenResponseBody setSid(String sid) {
        this.sid = sid;
        return this;
    }
    public String getSid() {
        return this.sid;
    }

    public GetYongYouOpenApiTokenResponseBody setYongyouOrgId(String yongyouOrgId) {
        this.yongyouOrgId = yongyouOrgId;
        return this;
    }
    public String getYongyouOrgId() {
        return this.yongyouOrgId;
    }

    public GetYongYouOpenApiTokenResponseBody setYongyouUserId(String yongyouUserId) {
        this.yongyouUserId = yongyouUserId;
        return this;
    }
    public String getYongyouUserId() {
        return this.yongyouUserId;
    }

}
