// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetIsvStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetIsvStatusResponseBody body;

    public static GetIsvStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        GetIsvStatusResponse self = new GetIsvStatusResponse();
        return TeaModel.build(map, self);
    }

    public GetIsvStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetIsvStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetIsvStatusResponse setBody(GetIsvStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public GetIsvStatusResponseBody getBody() {
        return this.body;
    }

}
