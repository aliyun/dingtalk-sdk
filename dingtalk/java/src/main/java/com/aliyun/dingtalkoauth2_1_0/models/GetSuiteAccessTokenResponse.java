// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetSuiteAccessTokenResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSuiteAccessTokenResponseBody body;

    public static GetSuiteAccessTokenResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSuiteAccessTokenResponse self = new GetSuiteAccessTokenResponse();
        return TeaModel.build(map, self);
    }

    public GetSuiteAccessTokenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSuiteAccessTokenResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSuiteAccessTokenResponse setBody(GetSuiteAccessTokenResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSuiteAccessTokenResponseBody getBody() {
        return this.body;
    }

}
