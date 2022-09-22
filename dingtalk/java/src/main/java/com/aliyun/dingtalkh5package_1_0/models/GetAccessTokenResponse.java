// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh5package_1_0.models;

import com.aliyun.tea.*;

public class GetAccessTokenResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetAccessTokenResponseBody body;

    public static GetAccessTokenResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAccessTokenResponse self = new GetAccessTokenResponse();
        return TeaModel.build(map, self);
    }

    public GetAccessTokenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAccessTokenResponse setBody(GetAccessTokenResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAccessTokenResponseBody getBody() {
        return this.body;
    }

}
