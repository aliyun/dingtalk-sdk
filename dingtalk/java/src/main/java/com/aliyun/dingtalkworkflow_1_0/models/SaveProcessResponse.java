// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SaveProcessResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SaveProcessResponseBody body;

    public static SaveProcessResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveProcessResponse self = new SaveProcessResponse();
        return TeaModel.build(map, self);
    }

    public SaveProcessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveProcessResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveProcessResponse setBody(SaveProcessResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveProcessResponseBody getBody() {
        return this.body;
    }

}
