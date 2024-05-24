// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SubmitTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SubmitTaskResponseBody body;

    public static SubmitTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        SubmitTaskResponse self = new SubmitTaskResponse();
        return TeaModel.build(map, self);
    }

    public SubmitTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SubmitTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SubmitTaskResponse setBody(SubmitTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public SubmitTaskResponseBody getBody() {
        return this.body;
    }

}
