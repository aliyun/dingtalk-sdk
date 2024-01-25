// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ProvidePointResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ProvidePointResponseBody body;

    public static ProvidePointResponse build(java.util.Map<String, ?> map) throws Exception {
        ProvidePointResponse self = new ProvidePointResponse();
        return TeaModel.build(map, self);
    }

    public ProvidePointResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ProvidePointResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ProvidePointResponse setBody(ProvidePointResponseBody body) {
        this.body = body;
        return this;
    }
    public ProvidePointResponseBody getBody() {
        return this.body;
    }

}
