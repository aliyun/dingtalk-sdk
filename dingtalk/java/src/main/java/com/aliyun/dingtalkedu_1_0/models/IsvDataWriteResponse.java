// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class IsvDataWriteResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public IsvDataWriteResponseBody body;

    public static IsvDataWriteResponse build(java.util.Map<String, ?> map) throws Exception {
        IsvDataWriteResponse self = new IsvDataWriteResponse();
        return TeaModel.build(map, self);
    }

    public IsvDataWriteResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IsvDataWriteResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IsvDataWriteResponse setBody(IsvDataWriteResponseBody body) {
        this.body = body;
        return this;
    }
    public IsvDataWriteResponseBody getBody() {
        return this.body;
    }

}
