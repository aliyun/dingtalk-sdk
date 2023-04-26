// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class AttendanceBleDevicesQueryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public AttendanceBleDevicesQueryResponseBody body;

    public static AttendanceBleDevicesQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        AttendanceBleDevicesQueryResponse self = new AttendanceBleDevicesQueryResponse();
        return TeaModel.build(map, self);
    }

    public AttendanceBleDevicesQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AttendanceBleDevicesQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AttendanceBleDevicesQueryResponse setBody(AttendanceBleDevicesQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public AttendanceBleDevicesQueryResponseBody getBody() {
        return this.body;
    }

}
