// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateTemplateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public BatchCreateTemplateResponse setBody(BatchCreateTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchCreateTemplateResponseBody getBody() {
        return this.body;
    }

}