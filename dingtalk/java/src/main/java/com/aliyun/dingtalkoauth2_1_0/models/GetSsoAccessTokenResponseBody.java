// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetSsoAccessTokenResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1234</p>
     */
    @NameInMap("accessToken")
    public String accessToken;

    /**
     * <strong>example:</strong>
     * <p>3600</p>
     */
    @NameInMap("expireIn")
    public Long expireIn;

    public static GetSsoAccessTokenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSsoAccessTokenResponseBody self = new GetSsoAccessTokenResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSsoAccessTokenResponseBody setAccessToken(String accessToken) {
        this.accessToken = accessToken;
        return this;
    }
    public String getAccessToken() {
        return this.accessToken;
    }

    public GetSsoAccessTokenResponseBody setExpireIn(Long expireIn) {
        this.expireIn = expireIn;
        return this;
    }
    public Long getExpireIn() {
        return this.expireIn;
    }

}
