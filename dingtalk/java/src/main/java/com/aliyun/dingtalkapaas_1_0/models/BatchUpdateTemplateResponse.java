// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateTemplateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public BatchUpdateTemplateResponse setBody(BatchUpdateTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchUpdateTemplateResponseBody getBody() {
        return this.body;
    }

}
