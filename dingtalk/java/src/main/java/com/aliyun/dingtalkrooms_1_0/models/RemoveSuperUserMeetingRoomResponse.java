// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class RemoveSuperUserMeetingRoomResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RemoveSuperUserMeetingRoomResponseBody body;

    public static RemoveSuperUserMeetingRoomResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveSuperUserMeetingRoomResponse self = new RemoveSuperUserMeetingRoomResponse();
        return TeaModel.build(map, self);
    }

    public RemoveSuperUserMeetingRoomResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RemoveSuperUserMeetingRoomResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RemoveSuperUserMeetingRoomResponse setBody(RemoveSuperUserMeetingRoomResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveSuperUserMeetingRoomResponseBody getBody() {
        return this.body;
    }

}
