// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class QueryRobotDingReadStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryRobotDingReadStatusResponseBody body;

    public static QueryRobotDingReadStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryRobotDingReadStatusResponse self = new QueryRobotDingReadStatusResponse();
        return TeaModel.build(map, self);
    }

    public QueryRobotDingReadStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryRobotDingReadStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryRobotDingReadStatusResponse setBody(QueryRobotDingReadStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRobotDingReadStatusResponseBody getBody() {
        return this.body;
    }

}
