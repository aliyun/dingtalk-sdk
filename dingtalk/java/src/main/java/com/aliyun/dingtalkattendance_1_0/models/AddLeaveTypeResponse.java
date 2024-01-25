// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class AddLeaveTypeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddLeaveTypeResponseBody body;

    public static AddLeaveTypeResponse build(java.util.Map<String, ?> map) throws Exception {
        AddLeaveTypeResponse self = new AddLeaveTypeResponse();
        return TeaModel.build(map, self);
    }

    public AddLeaveTypeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddLeaveTypeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddLeaveTypeResponse setBody(AddLeaveTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public AddLeaveTypeResponseBody getBody() {
        return this.body;
    }

}
