// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetProcessStartUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetProcessStartUrlResponseBody body;

    public static GetProcessStartUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetProcessStartUrlResponse self = new GetProcessStartUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetProcessStartUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetProcessStartUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetProcessStartUrlResponse setBody(GetProcessStartUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProcessStartUrlResponseBody getBody() {
        return this.body;
    }

}
