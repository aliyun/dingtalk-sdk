// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class RecallAuditTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public RecallAuditTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RecallAuditTemplateResponse setBody(RecallAuditTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public RecallAuditTemplateResponseBody getBody() {
        return this.body;
    }

}
