// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetAccessTokenRequest extends TeaModel {
    /**
     * <p>应用id</p>
     */
    @NameInMap("appKey")
    public String appKey;

    /**
     * <p>应用密码</p>
     */
    @NameInMap("appSecret")
    public String appSecret;

    public static GetAccessTokenRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAccessTokenRequest self = new GetAccessTokenRequest();
        return TeaModel.build(map, self);
    }

    public GetAccessTokenRequest setAppKey(String appKey) {
        this.appKey = appKey;
        return this;
    }
    public String getAppKey() {
        return this.appKey;
    }

    public GetAccessTokenRequest setAppSecret(String appSecret) {
        this.appSecret = appSecret;
        return this;
    }
    public String getAppSecret() {
        return this.appSecret;
    }

}
