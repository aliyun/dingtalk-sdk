// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class AuthUrlRequest extends TeaModel {
    @NameInMap("redirectUrl")
    public String redirectUrl;

    public static AuthUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        AuthUrlRequest self = new AuthUrlRequest();
        return TeaModel.build(map, self);
    }

    public AuthUrlRequest setRedirectUrl(String redirectUrl) {
        this.redirectUrl = redirectUrl;
        return this;
    }
    public String getRedirectUrl() {
        return this.redirectUrl;
    }

}
