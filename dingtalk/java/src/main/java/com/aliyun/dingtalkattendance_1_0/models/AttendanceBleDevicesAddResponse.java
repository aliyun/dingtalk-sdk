// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class AttendanceBleDevicesAddResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AttendanceBleDevicesAddResponseBody body;

    public static AttendanceBleDevicesAddResponse build(java.util.Map<String, ?> map) throws Exception {
        AttendanceBleDevicesAddResponse self = new AttendanceBleDevicesAddResponse();
        return TeaModel.build(map, self);
    }

    public AttendanceBleDevicesAddResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AttendanceBleDevicesAddResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AttendanceBleDevicesAddResponse setBody(AttendanceBleDevicesAddResponseBody body) {
        this.body = body;
        return this;
    }
    public AttendanceBleDevicesAddResponseBody getBody() {
        return this.body;
    }

}
