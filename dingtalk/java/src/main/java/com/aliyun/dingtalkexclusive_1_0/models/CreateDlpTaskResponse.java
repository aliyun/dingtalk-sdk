// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateDlpTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateDlpTaskResponseBody body;

    public static CreateDlpTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateDlpTaskResponse self = new CreateDlpTaskResponse();
        return TeaModel.build(map, self);
    }

    public CreateDlpTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateDlpTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateDlpTaskResponse setBody(CreateDlpTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateDlpTaskResponseBody getBody() {
        return this.body;
    }

}
