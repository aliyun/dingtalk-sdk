// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class MeetingRoomRespondResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public MeetingRoomRespondResponseBody body;

    public static MeetingRoomRespondResponse build(java.util.Map<String, ?> map) throws Exception {
        MeetingRoomRespondResponse self = new MeetingRoomRespondResponse();
        return TeaModel.build(map, self);
    }

    public MeetingRoomRespondResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public MeetingRoomRespondResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public MeetingRoomRespondResponse setBody(MeetingRoomRespondResponseBody body) {
        this.body = body;
        return this;
    }
    public MeetingRoomRespondResponseBody getBody() {
        return this.body;
    }

}
