// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListAttendeesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListAttendeesResponseBody body;

    public static ListAttendeesResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAttendeesResponse self = new ListAttendeesResponse();
        return TeaModel.build(map, self);
    }

    public ListAttendeesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAttendeesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListAttendeesResponse setBody(ListAttendeesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAttendeesResponseBody getBody() {
        return this.body;
    }

}
