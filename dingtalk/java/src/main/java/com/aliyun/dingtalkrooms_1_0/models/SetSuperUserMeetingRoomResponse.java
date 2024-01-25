// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class SetSuperUserMeetingRoomResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetSuperUserMeetingRoomResponseBody body;

    public static SetSuperUserMeetingRoomResponse build(java.util.Map<String, ?> map) throws Exception {
        SetSuperUserMeetingRoomResponse self = new SetSuperUserMeetingRoomResponse();
        return TeaModel.build(map, self);
    }

    public SetSuperUserMeetingRoomResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetSuperUserMeetingRoomResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetSuperUserMeetingRoomResponse setBody(SetSuperUserMeetingRoomResponseBody body) {
        this.body = body;
        return this;
    }
    public SetSuperUserMeetingRoomResponseBody getBody() {
        return this.body;
    }

}
