// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class RetainLeaveTypesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RetainLeaveTypesResponseBody body;

    public static RetainLeaveTypesResponse build(java.util.Map<String, ?> map) throws Exception {
        RetainLeaveTypesResponse self = new RetainLeaveTypesResponse();
        return TeaModel.build(map, self);
    }

    public RetainLeaveTypesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RetainLeaveTypesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RetainLeaveTypesResponse setBody(RetainLeaveTypesResponseBody body) {
        this.body = body;
        return this;
    }
    public RetainLeaveTypesResponseBody getBody() {
        return this.body;
    }

}
