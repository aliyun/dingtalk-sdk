// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomControlPanelListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMeetingRoomControlPanelListResponseBody body;

    public static QueryMeetingRoomControlPanelListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomControlPanelListResponse self = new QueryMeetingRoomControlPanelListResponse();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomControlPanelListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMeetingRoomControlPanelListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMeetingRoomControlPanelListResponse setBody(QueryMeetingRoomControlPanelListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMeetingRoomControlPanelListResponseBody getBody() {
        return this.body;
    }

}
