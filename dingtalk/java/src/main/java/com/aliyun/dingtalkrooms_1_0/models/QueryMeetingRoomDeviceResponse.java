// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomDeviceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMeetingRoomDeviceResponseBody body;

    public static QueryMeetingRoomDeviceResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomDeviceResponse self = new QueryMeetingRoomDeviceResponse();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomDeviceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMeetingRoomDeviceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMeetingRoomDeviceResponse setBody(QueryMeetingRoomDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMeetingRoomDeviceResponseBody getBody() {
        return this.body;
    }

}
