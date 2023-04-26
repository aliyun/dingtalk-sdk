// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class AddApplicationRegFormTemplateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public AddApplicationRegFormTemplateResponseBody body;

    public static AddApplicationRegFormTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        AddApplicationRegFormTemplateResponse self = new AddApplicationRegFormTemplateResponse();
        return TeaModel.build(map, self);
    }

    public AddApplicationRegFormTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddApplicationRegFormTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddApplicationRegFormTemplateResponse setBody(AddApplicationRegFormTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public AddApplicationRegFormTemplateResponseBody getBody() {
        return this.body;
    }

}
