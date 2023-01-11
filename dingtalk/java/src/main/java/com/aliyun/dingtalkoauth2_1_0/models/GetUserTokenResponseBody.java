// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetUserTokenResponseBody extends TeaModel {
    /**
     * <p>accessToken</p>
     */
    @NameInMap("accessToken")
    public String accessToken;

    /**
     * <p>所选企业corpId</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>超时时间</p>
     */
    @NameInMap("expireIn")
    public Long expireIn;

    /**
     * <p>refreshToken</p>
     */
    @NameInMap("refreshToken")
    public String refreshToken;

    public static GetUserTokenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserTokenResponseBody self = new GetUserTokenResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserTokenResponseBody setAccessToken(String accessToken) {
        this.accessToken = accessToken;
        return this;
    }
    public String getAccessToken() {
        return this.accessToken;
    }

    public GetUserTokenResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetUserTokenResponseBody setExpireIn(Long expireIn) {
        this.expireIn = expireIn;
        return this;
    }
    public Long getExpireIn() {
        return this.expireIn;
    }

    public GetUserTokenResponseBody setRefreshToken(String refreshToken) {
        this.refreshToken = refreshToken;
        return this;
    }
    public String getRefreshToken() {
        return this.refreshToken;
    }

}
