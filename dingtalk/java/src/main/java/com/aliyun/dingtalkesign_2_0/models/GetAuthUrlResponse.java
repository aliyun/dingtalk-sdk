// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetAuthUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAuthUrlResponseBody body;

    public static GetAuthUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAuthUrlResponse self = new GetAuthUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetAuthUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAuthUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAuthUrlResponse setBody(GetAuthUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAuthUrlResponseBody getBody() {
        return this.body;
    }

}
