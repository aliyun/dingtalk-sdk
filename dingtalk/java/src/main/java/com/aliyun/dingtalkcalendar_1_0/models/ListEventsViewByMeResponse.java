// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListEventsViewByMeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListEventsViewByMeResponseBody body;

    public static ListEventsViewByMeResponse build(java.util.Map<String, ?> map) throws Exception {
        ListEventsViewByMeResponse self = new ListEventsViewByMeResponse();
        return TeaModel.build(map, self);
    }

    public ListEventsViewByMeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListEventsViewByMeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListEventsViewByMeResponse setBody(ListEventsViewByMeResponseBody body) {
        this.body = body;
        return this;
    }
    public ListEventsViewByMeResponseBody getBody() {
        return this.body;
    }

}
