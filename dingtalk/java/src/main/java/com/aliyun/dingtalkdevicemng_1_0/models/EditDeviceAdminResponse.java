// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class EditDeviceAdminResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public EditDeviceAdminResponseBody body;

    public static EditDeviceAdminResponse build(java.util.Map<String, ?> map) throws Exception {
        EditDeviceAdminResponse self = new EditDeviceAdminResponse();
        return TeaModel.build(map, self);
    }

    public EditDeviceAdminResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditDeviceAdminResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EditDeviceAdminResponse setBody(EditDeviceAdminResponseBody body) {
        this.body = body;
        return this;
    }
    public EditDeviceAdminResponseBody getBody() {
        return this.body;
    }

}
