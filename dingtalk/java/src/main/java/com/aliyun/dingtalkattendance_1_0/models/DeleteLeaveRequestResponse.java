// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class DeleteLeaveRequestResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteLeaveRequestResponseBody body;

    public static DeleteLeaveRequestResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteLeaveRequestResponse self = new DeleteLeaveRequestResponse();
        return TeaModel.build(map, self);
    }

    public DeleteLeaveRequestResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteLeaveRequestResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteLeaveRequestResponse setBody(DeleteLeaveRequestResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteLeaveRequestResponseBody getBody() {
        return this.body;
    }

}
