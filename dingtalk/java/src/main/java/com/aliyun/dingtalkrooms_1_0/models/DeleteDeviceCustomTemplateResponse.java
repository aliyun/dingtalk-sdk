// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class DeleteDeviceCustomTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteDeviceCustomTemplateResponseBody body;

    public static DeleteDeviceCustomTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteDeviceCustomTemplateResponse self = new DeleteDeviceCustomTemplateResponse();
        return TeaModel.build(map, self);
    }

    public DeleteDeviceCustomTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteDeviceCustomTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteDeviceCustomTemplateResponse setBody(DeleteDeviceCustomTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteDeviceCustomTemplateResponseBody getBody() {
        return this.body;
    }

}
