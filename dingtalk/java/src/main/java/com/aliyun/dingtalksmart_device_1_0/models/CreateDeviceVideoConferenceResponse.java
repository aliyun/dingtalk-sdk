// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class CreateDeviceVideoConferenceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateDeviceVideoConferenceResponseBody body;

    public static CreateDeviceVideoConferenceResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateDeviceVideoConferenceResponse self = new CreateDeviceVideoConferenceResponse();
        return TeaModel.build(map, self);
    }

    public CreateDeviceVideoConferenceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateDeviceVideoConferenceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateDeviceVideoConferenceResponse setBody(CreateDeviceVideoConferenceResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateDeviceVideoConferenceResponseBody getBody() {
        return this.body;
    }

}
