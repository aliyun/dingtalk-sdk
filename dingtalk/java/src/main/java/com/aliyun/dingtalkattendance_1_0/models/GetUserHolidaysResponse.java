// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetUserHolidaysResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUserHolidaysResponseBody body;

    public static GetUserHolidaysResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserHolidaysResponse self = new GetUserHolidaysResponse();
        return TeaModel.build(map, self);
    }

    public GetUserHolidaysResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserHolidaysResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserHolidaysResponse setBody(GetUserHolidaysResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserHolidaysResponseBody getBody() {
        return this.body;
    }

}
