// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class SubmitAsrTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SubmitAsrTaskResponseBody body;

    public static SubmitAsrTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        SubmitAsrTaskResponse self = new SubmitAsrTaskResponse();
        return TeaModel.build(map, self);
    }

    public SubmitAsrTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SubmitAsrTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SubmitAsrTaskResponse setBody(SubmitAsrTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public SubmitAsrTaskResponseBody getBody() {
        return this.body;
    }

}
