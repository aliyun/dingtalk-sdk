// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class UnsubscribeCalendarResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public UnsubscribeCalendarResponse setBody(UnsubscribeCalendarResponseBody body) {
        this.body = body;
        return this;
    }
    public UnsubscribeCalendarResponseBody getBody() {
        return this.body;
    }

}
