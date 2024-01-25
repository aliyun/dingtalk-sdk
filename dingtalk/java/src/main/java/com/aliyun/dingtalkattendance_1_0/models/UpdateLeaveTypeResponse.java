// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class UpdateLeaveTypeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateLeaveTypeResponseBody body;

    public static UpdateLeaveTypeResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateLeaveTypeResponse self = new UpdateLeaveTypeResponse();
        return TeaModel.build(map, self);
    }

    public UpdateLeaveTypeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateLeaveTypeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateLeaveTypeResponse setBody(UpdateLeaveTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateLeaveTypeResponseBody getBody() {
        return this.body;
    }

}
