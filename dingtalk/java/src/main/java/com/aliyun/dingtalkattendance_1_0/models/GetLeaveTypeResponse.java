// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetLeaveTypeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetLeaveTypeResponseBody body;

    public static GetLeaveTypeResponse build(java.util.Map<String, ?> map) throws Exception {
        GetLeaveTypeResponse self = new GetLeaveTypeResponse();
        return TeaModel.build(map, self);
    }

    public GetLeaveTypeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetLeaveTypeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetLeaveTypeResponse setBody(GetLeaveTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetLeaveTypeResponseBody getBody() {
        return this.body;
    }

}
