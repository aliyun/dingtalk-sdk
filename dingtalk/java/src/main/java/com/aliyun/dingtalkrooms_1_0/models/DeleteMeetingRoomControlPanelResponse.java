// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class DeleteMeetingRoomControlPanelResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteMeetingRoomControlPanelResponseBody body;

    public static DeleteMeetingRoomControlPanelResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteMeetingRoomControlPanelResponse self = new DeleteMeetingRoomControlPanelResponse();
        return TeaModel.build(map, self);
    }

    public DeleteMeetingRoomControlPanelResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteMeetingRoomControlPanelResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteMeetingRoomControlPanelResponse setBody(DeleteMeetingRoomControlPanelResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteMeetingRoomControlPanelResponseBody getBody() {
        return this.body;
    }

}
