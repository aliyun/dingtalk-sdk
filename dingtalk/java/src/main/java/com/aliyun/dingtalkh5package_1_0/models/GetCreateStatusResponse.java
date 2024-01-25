// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh5package_1_0.models;

import com.aliyun.tea.*;

public class GetCreateStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCreateStatusResponseBody body;

    public static GetCreateStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCreateStatusResponse self = new GetCreateStatusResponse();
        return TeaModel.build(map, self);
    }

    public GetCreateStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCreateStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCreateStatusResponse setBody(GetCreateStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCreateStatusResponseBody getBody() {
        return this.body;
    }

}
