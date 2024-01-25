// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class GetPointInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPointInfoResponseBody body;

    public static GetPointInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPointInfoResponse self = new GetPointInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetPointInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPointInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPointInfoResponse setBody(GetPointInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPointInfoResponseBody getBody() {
        return this.body;
    }

}
