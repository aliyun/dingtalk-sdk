// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class DeleteMeetingRoomResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteMeetingRoomResponseBody body;

    public static DeleteMeetingRoomResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteMeetingRoomResponse self = new DeleteMeetingRoomResponse();
        return TeaModel.build(map, self);
    }

    public DeleteMeetingRoomResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteMeetingRoomResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteMeetingRoomResponse setBody(DeleteMeetingRoomResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteMeetingRoomResponseBody getBody() {
        return this.body;
    }

}
