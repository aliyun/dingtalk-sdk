// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class GetShanhuiByCalendarResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetShanhuiByCalendarResponseBody body;

    public static GetShanhuiByCalendarResponse build(java.util.Map<String, ?> map) throws Exception {
        GetShanhuiByCalendarResponse self = new GetShanhuiByCalendarResponse();
        return TeaModel.build(map, self);
    }

    public GetShanhuiByCalendarResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetShanhuiByCalendarResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetShanhuiByCalendarResponse setBody(GetShanhuiByCalendarResponseBody body) {
        this.body = body;
        return this;
    }
    public GetShanhuiByCalendarResponseBody getBody() {
        return this.body;
    }

}
