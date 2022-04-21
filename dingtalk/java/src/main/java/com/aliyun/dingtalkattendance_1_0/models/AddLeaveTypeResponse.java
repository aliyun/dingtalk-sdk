// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class AddLeaveTypeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public AddLeaveTypeResponse setBody(AddLeaveTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public AddLeaveTypeResponseBody getBody() {
        return this.body;
    }

}
