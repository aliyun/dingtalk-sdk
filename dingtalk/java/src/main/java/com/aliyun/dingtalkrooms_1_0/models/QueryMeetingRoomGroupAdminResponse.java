// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomGroupAdminResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMeetingRoomGroupAdminResponseBody body;

    public static QueryMeetingRoomGroupAdminResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomGroupAdminResponse self = new QueryMeetingRoomGroupAdminResponse();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomGroupAdminResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMeetingRoomGroupAdminResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMeetingRoomGroupAdminResponse setBody(QueryMeetingRoomGroupAdminResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMeetingRoomGroupAdminResponseBody getBody() {
        return this.body;
    }

}
