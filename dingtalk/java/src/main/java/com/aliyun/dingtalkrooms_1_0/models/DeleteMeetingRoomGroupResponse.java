// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class DeleteMeetingRoomGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteMeetingRoomGroupResponseBody body;

    public static DeleteMeetingRoomGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteMeetingRoomGroupResponse self = new DeleteMeetingRoomGroupResponse();
        return TeaModel.build(map, self);
    }

    public DeleteMeetingRoomGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteMeetingRoomGroupResponse setBody(DeleteMeetingRoomGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteMeetingRoomGroupResponseBody getBody() {
        return this.body;
    }

}
