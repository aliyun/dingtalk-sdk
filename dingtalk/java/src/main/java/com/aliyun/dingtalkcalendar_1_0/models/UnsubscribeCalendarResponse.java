// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class UnsubscribeCalendarResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UnsubscribeCalendarResponseBody body;

    public static UnsubscribeCalendarResponse build(java.util.Map<String, ?> map) throws Exception {
        UnsubscribeCalendarResponse self = new UnsubscribeCalendarResponse();
        return TeaModel.build(map, self);
    }

    public UnsubscribeCalendarResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UnsubscribeCalendarResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UnsubscribeCalendarResponse setBody(UnsubscribeCalendarResponseBody body) {
        this.body = body;
        return this;
    }
    public UnsubscribeCalendarResponseBody getBody() {
        return this.body;
    }

}
