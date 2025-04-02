// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EventTrackResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EventTrackResponseBody body;

    public static EventTrackResponse build(java.util.Map<String, ?> map) throws Exception {
        EventTrackResponse self = new EventTrackResponse();
        return TeaModel.build(map, self);
    }

    public EventTrackResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EventTrackResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EventTrackResponse setBody(EventTrackResponseBody body) {
        this.body = body;
        return this;
    }
    public EventTrackResponseBody getBody() {
        return this.body;
    }

}
