// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateDeviceCustomTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateDeviceCustomTemplateResponseBody body;

    public static CreateDeviceCustomTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateDeviceCustomTemplateResponse self = new CreateDeviceCustomTemplateResponse();
        return TeaModel.build(map, self);
    }

    public CreateDeviceCustomTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateDeviceCustomTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateDeviceCustomTemplateResponse setBody(CreateDeviceCustomTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateDeviceCustomTemplateResponseBody getBody() {
        return this.body;
    }

}
