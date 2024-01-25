// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class PreCheckTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PreCheckTemplateResponseBody body;

    public static PreCheckTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        PreCheckTemplateResponse self = new PreCheckTemplateResponse();
        return TeaModel.build(map, self);
    }

    public PreCheckTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PreCheckTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PreCheckTemplateResponse setBody(PreCheckTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public PreCheckTemplateResponseBody getBody() {
        return this.body;
    }

}
