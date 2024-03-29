// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0.models;

import com.aliyun.tea.*;

public class CloseTopboxResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CloseTopboxResponseBody body;

    public static CloseTopboxResponse build(java.util.Map<String, ?> map) throws Exception {
        CloseTopboxResponse self = new CloseTopboxResponse();
        return TeaModel.build(map, self);
    }

    public CloseTopboxResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CloseTopboxResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CloseTopboxResponse setBody(CloseTopboxResponseBody body) {
        this.body = body;
        return this;
    }
    public CloseTopboxResponseBody getBody() {
        return this.body;
    }

}
