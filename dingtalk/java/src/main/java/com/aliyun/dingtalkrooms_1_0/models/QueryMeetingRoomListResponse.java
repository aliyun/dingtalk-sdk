// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryMeetingRoomListResponseBody body;

    public static QueryMeetingRoomListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomListResponse self = new QueryMeetingRoomListResponse();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMeetingRoomListResponse setBody(QueryMeetingRoomListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMeetingRoomListResponseBody getBody() {
        return this.body;
    }

}
