// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class RecallAuditTemplateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public RecallAuditTemplateResponseBody body;

    public static RecallAuditTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        RecallAuditTemplateResponse self = new RecallAuditTemplateResponse();
        return TeaModel.build(map, self);
    }

    public RecallAuditTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RecallAuditTemplateResponse setBody(RecallAuditTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public RecallAuditTemplateResponseBody getBody() {
        return this.body;
    }

}
