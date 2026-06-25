// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class QueryRobotInstanceInGroupInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryRobotInstanceInGroupInfoResponseBody body;

    public static QueryRobotInstanceInGroupInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryRobotInstanceInGroupInfoResponse self = new QueryRobotInstanceInGroupInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryRobotInstanceInGroupInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryRobotInstanceInGroupInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryRobotInstanceInGroupInfoResponse setBody(QueryRobotInstanceInGroupInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRobotInstanceInGroupInfoResponseBody getBody() {
        return this.body;
    }

}
