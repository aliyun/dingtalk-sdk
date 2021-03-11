// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetUserHolidaysResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetUserHolidaysResponse setBody(GetUserHolidaysResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserHolidaysResponseBody getBody() {
        return this.body;
    }

}
