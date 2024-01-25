// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetSsoAccessTokenResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetSsoAccessTokenResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSsoAccessTokenResponse setBody(GetSsoAccessTokenResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSsoAccessTokenResponseBody getBody() {
        return this.body;
    }

}
