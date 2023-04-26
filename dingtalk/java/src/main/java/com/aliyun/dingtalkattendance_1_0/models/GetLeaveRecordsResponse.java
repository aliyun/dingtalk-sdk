// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetLeaveRecordsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetLeaveRecordsResponseBody body;

    public static GetLeaveRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetLeaveRecordsResponse self = new GetLeaveRecordsResponse();
        return TeaModel.build(map, self);
    }

    public GetLeaveRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetLeaveRecordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetLeaveRecordsResponse setBody(GetLeaveRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetLeaveRecordsResponseBody getBody() {
        return this.body;
    }

}
