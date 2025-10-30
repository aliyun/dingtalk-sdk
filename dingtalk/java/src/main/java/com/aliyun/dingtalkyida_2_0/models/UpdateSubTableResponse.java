// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class UpdateSubTableResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateSubTableResponseBody body;

    public static UpdateSubTableResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateSubTableResponse self = new UpdateSubTableResponse();
        return TeaModel.build(map, self);
    }

    public UpdateSubTableResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateSubTableResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateSubTableResponse setBody(UpdateSubTableResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateSubTableResponseBody getBody() {
        return this.body;
    }

}
