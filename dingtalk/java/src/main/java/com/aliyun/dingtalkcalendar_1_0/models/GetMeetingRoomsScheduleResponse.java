// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetMeetingRoomsScheduleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetMeetingRoomsScheduleResponseBody body;

    public static GetMeetingRoomsScheduleResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMeetingRoomsScheduleResponse self = new GetMeetingRoomsScheduleResponse();
        return TeaModel.build(map, self);
    }

    public GetMeetingRoomsScheduleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMeetingRoomsScheduleResponse setBody(GetMeetingRoomsScheduleResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMeetingRoomsScheduleResponseBody getBody() {
        return this.body;
    }

}
