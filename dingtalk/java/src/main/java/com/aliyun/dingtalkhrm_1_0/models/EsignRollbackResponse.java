// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class EsignRollbackResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public EsignRollbackResponseBody body;

    public static EsignRollbackResponse build(java.util.Map<String, ?> map) throws Exception {
        EsignRollbackResponse self = new EsignRollbackResponse();
        return TeaModel.build(map, self);
    }

    public EsignRollbackResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EsignRollbackResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EsignRollbackResponse setBody(EsignRollbackResponseBody body) {
        this.body = body;
        return this;
    }
    public EsignRollbackResponseBody getBody() {
        return this.body;
    }

}
