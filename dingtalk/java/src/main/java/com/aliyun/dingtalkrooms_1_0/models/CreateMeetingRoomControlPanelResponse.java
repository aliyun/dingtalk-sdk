// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateMeetingRoomControlPanelResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateMeetingRoomControlPanelResponseBody body;

    public static CreateMeetingRoomControlPanelResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateMeetingRoomControlPanelResponse self = new CreateMeetingRoomControlPanelResponse();
        return TeaModel.build(map, self);
    }

    public CreateMeetingRoomControlPanelResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateMeetingRoomControlPanelResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateMeetingRoomControlPanelResponse setBody(CreateMeetingRoomControlPanelResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateMeetingRoomControlPanelResponseBody getBody() {
        return this.body;
    }

}
