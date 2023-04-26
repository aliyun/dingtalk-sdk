// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetCorpAccessTokenResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetCorpAccessTokenResponseBody body;

    public static GetCorpAccessTokenResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCorpAccessTokenResponse self = new GetCorpAccessTokenResponse();
        return TeaModel.build(map, self);
    }

    public GetCorpAccessTokenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCorpAccessTokenResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCorpAccessTokenResponse setBody(GetCorpAccessTokenResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCorpAccessTokenResponseBody getBody() {
        return this.body;
    }

}
