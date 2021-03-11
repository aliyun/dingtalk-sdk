// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetCorpAccessTokenResponseBody extends TeaModel {
    // accessToken
    @NameInMap("accessToken")
    public String accessToken;

    // 超时时间
    @NameInMap("expireIn")
    public Long expireIn;

    public static GetCorpAccessTokenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCorpAccessTokenResponseBody self = new GetCorpAccessTokenResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCorpAccessTokenResponseBody setAccessToken(String accessToken) {
        this.accessToken = accessToken;
        return this;
    }
    public String getAccessToken() {
        return this.accessToken;
    }

    public GetCorpAccessTokenResponseBody setExpireIn(Long expireIn) {
        this.expireIn = expireIn;
        return this;
    }
    public Long getExpireIn() {
        return this.expireIn;
    }

}
