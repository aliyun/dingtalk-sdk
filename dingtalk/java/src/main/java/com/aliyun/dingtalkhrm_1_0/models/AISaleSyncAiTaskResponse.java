// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleSyncAiTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AISaleSyncAiTaskResponseBody body;

    public static AISaleSyncAiTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        AISaleSyncAiTaskResponse self = new AISaleSyncAiTaskResponse();
        return TeaModel.build(map, self);
    }

    public AISaleSyncAiTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AISaleSyncAiTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AISaleSyncAiTaskResponse setBody(AISaleSyncAiTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public AISaleSyncAiTaskResponseBody getBody() {
        return this.body;
    }

}
