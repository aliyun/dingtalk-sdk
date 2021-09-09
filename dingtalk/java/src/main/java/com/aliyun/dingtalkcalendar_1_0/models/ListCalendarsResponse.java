// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListCalendarsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListCalendarsResponseBody body;

    public static ListCalendarsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListCalendarsResponse self = new ListCalendarsResponse();
        return TeaModel.build(map, self);
    }

    public ListCalendarsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListCalendarsResponse setBody(ListCalendarsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListCalendarsResponseBody getBody() {
        return this.body;
    }

}
