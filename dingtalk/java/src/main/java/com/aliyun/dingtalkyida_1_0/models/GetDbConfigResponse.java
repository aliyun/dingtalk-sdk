// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetDbConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDbConfigResponseBody body;

    public static GetDbConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDbConfigResponse self = new GetDbConfigResponse();
        return TeaModel.build(map, self);
    }

    public GetDbConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDbConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDbConfigResponse setBody(GetDbConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDbConfigResponseBody getBody() {
        return this.body;
    }

}
