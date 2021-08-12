// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class AttendanceBleDevicesRemoveResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AttendanceBleDevicesRemoveResponseBody body;

    public static AttendanceBleDevicesRemoveResponse build(java.util.Map<String, ?> map) throws Exception {
        AttendanceBleDevicesRemoveResponse self = new AttendanceBleDevicesRemoveResponse();
        return TeaModel.build(map, self);
    }

    public AttendanceBleDevicesRemoveResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AttendanceBleDevicesRemoveResponse setBody(AttendanceBleDevicesRemoveResponseBody body) {
        this.body = body;
        return this;
    }
    public AttendanceBleDevicesRemoveResponseBody getBody() {
        return this.body;
    }

}
