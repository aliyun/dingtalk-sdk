// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetInterconnectionUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetInterconnectionUrlResponseBody body;

    public static GetInterconnectionUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetInterconnectionUrlResponse self = new GetInterconnectionUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetInterconnectionUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetInterconnectionUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetInterconnectionUrlResponse setBody(GetInterconnectionUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetInterconnectionUrlResponseBody getBody() {
        return this.body;
    }

}
