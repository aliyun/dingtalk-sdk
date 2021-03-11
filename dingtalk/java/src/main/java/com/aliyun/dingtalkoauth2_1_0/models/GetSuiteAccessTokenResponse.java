// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetSuiteAccessTokenResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetSuiteAccessTokenResponse setBody(GetSuiteAccessTokenResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSuiteAccessTokenResponseBody getBody() {
        return this.body;
    }

}
