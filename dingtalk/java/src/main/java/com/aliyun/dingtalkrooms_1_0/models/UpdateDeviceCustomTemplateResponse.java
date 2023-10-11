// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class UpdateDeviceCustomTemplateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateDeviceCustomTemplateResponseBody body;

    public static UpdateDeviceCustomTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateDeviceCustomTemplateResponse self = new UpdateDeviceCustomTemplateResponse();
        return TeaModel.build(map, self);
    }

    public UpdateDeviceCustomTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateDeviceCustomTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateDeviceCustomTemplateResponse setBody(UpdateDeviceCustomTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateDeviceCustomTemplateResponseBody getBody() {
        return this.body;
    }

}
