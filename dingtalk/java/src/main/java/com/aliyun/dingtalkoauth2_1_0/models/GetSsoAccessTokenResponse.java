// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetSsoAccessTokenResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetSsoAccessTokenResponseBody body;

    public static GetSsoAccessTokenResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSsoAccessTokenResponse self = new GetSsoAccessTokenResponse();
        return TeaModel.build(map, self);
    }

    public GetSsoAccessTokenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSsoAccessTokenResponse setBody(GetSsoAccessTokenResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSsoAccessTokenResponseBody getBody() {
        return this.body;
    }

}
