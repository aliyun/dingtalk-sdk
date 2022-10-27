// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class UpdateMeetingRoomResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateMeetingRoomResponseBody body;

    public static UpdateMeetingRoomResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateMeetingRoomResponse self = new UpdateMeetingRoomResponse();
        return TeaModel.build(map, self);
    }

    public UpdateMeetingRoomResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateMeetingRoomResponse setBody(UpdateMeetingRoomResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateMeetingRoomResponseBody getBody() {
        return this.body;
    }

}
