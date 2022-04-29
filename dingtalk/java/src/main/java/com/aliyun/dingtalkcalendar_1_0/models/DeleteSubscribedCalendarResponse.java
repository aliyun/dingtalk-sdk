// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class DeleteSubscribedCalendarResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteSubscribedCalendarResponseBody body;

    public static DeleteSubscribedCalendarResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteSubscribedCalendarResponse self = new DeleteSubscribedCalendarResponse();
        return TeaModel.build(map, self);
    }

    public DeleteSubscribedCalendarResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteSubscribedCalendarResponse setBody(DeleteSubscribedCalendarResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteSubscribedCalendarResponseBody getBody() {
        return this.body;
    }

}
