// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetShiftResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetShiftResponseBody body;

    public static GetShiftResponse build(java.util.Map<String, ?> map) throws Exception {
        GetShiftResponse self = new GetShiftResponse();
        return TeaModel.build(map, self);
    }

    public GetShiftResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetShiftResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetShiftResponse setBody(GetShiftResponseBody body) {
        this.body = body;
        return this;
    }
    public GetShiftResponseBody getBody() {
        return this.body;
    }

}
