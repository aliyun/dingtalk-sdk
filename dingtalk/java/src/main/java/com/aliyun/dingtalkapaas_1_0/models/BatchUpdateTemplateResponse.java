// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchUpdateTemplateResponseBody body;

    public static BatchUpdateTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateTemplateResponse self = new BatchUpdateTemplateResponse();
        return TeaModel.build(map, self);
    }

    public BatchUpdateTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchUpdateTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchUpdateTemplateResponse setBody(BatchUpdateTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchUpdateTemplateResponseBody getBody() {
        return this.body;
    }

}
