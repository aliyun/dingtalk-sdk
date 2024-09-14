// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class SaveTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SaveTemplateResponseBody body;

    public static SaveTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveTemplateResponse self = new SaveTemplateResponse();
        return TeaModel.build(map, self);
    }

    public SaveTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveTemplateResponse setBody(SaveTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveTemplateResponseBody getBody() {
        return this.body;
    }

}
