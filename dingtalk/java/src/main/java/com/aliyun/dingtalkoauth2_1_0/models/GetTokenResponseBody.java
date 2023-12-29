// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetTokenResponseBody extends TeaModel {
    @NameInMap("access_token")
    public String accessToken;

    @NameInMap("expires_in")
    public Integer expiresIn;

    public static GetTokenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTokenResponseBody self = new GetTokenResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTokenResponseBody setAccessToken(String accessToken) {
        this.accessToken = accessToken;
        return this;
    }
    public String getAccessToken() {
        return this.accessToken;
    }

    public GetTokenResponseBody setExpiresIn(Integer expiresIn) {
        this.expiresIn = expiresIn;
        return this;
    }
    public Integer getExpiresIn() {
        return this.expiresIn;
    }

}
