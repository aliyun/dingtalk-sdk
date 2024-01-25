// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchCreateTemplateResponseBody body;

    public static BatchCreateTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateTemplateResponse self = new BatchCreateTemplateResponse();
        return TeaModel.build(map, self);
    }

    public BatchCreateTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchCreateTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchCreateTemplateResponse setBody(BatchCreateTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchCreateTemplateResponseBody getBody() {
        return this.body;
    }

}
