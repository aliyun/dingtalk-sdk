// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class FormCreateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public FormCreateResponseBody body;

    public static FormCreateResponse build(java.util.Map<String, ?> map) throws Exception {
        FormCreateResponse self = new FormCreateResponse();
        return TeaModel.build(map, self);
    }

    public FormCreateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public FormCreateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public FormCreateResponse setBody(FormCreateResponseBody body) {
        this.body = body;
        return this;
    }
    public FormCreateResponseBody getBody() {
        return this.body;
    }

}
