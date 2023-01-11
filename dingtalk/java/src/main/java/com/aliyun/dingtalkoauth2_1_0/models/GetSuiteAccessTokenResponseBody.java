// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetSuiteAccessTokenResponseBody extends TeaModel {
    /**
     * <p>accessToken</p>
     */
    @NameInMap("accessToken")
    public String accessToken;

    /**
     * <p>超时时间</p>
     */
    @NameInMap("expireIn")
    public Long expireIn;

    public static GetSuiteAccessTokenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSuiteAccessTokenResponseBody self = new GetSuiteAccessTokenResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSuiteAccessTokenResponseBody setAccessToken(String accessToken) {
        this.accessToken = accessToken;
        return this;
    }
    public String getAccessToken() {
        return this.accessToken;
    }

    public GetSuiteAccessTokenResponseBody setExpireIn(Long expireIn) {
        this.expireIn = expireIn;
        return this;
    }
    public Long getExpireIn() {
        return this.expireIn;
    }

}
