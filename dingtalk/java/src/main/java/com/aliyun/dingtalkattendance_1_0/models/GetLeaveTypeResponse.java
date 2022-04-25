// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetLeaveTypeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetLeaveTypeResponse setBody(GetLeaveTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetLeaveTypeResponseBody getBody() {
        return this.body;
    }

}
