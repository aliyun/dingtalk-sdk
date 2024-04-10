// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetColumnvalsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetColumnvalsResponseBody body;

    public static GetColumnvalsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetColumnvalsResponse self = new GetColumnvalsResponse();
        return TeaModel.build(map, self);
    }

    public GetColumnvalsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetColumnvalsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetColumnvalsResponse setBody(GetColumnvalsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetColumnvalsResponseBody getBody() {
        return this.body;
    }

}
