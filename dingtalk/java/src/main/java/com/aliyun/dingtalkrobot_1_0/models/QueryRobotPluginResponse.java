// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class QueryRobotPluginResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryRobotPluginResponseBody body;

    public static QueryRobotPluginResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryRobotPluginResponse self = new QueryRobotPluginResponse();
        return TeaModel.build(map, self);
    }

    public QueryRobotPluginResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryRobotPluginResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryRobotPluginResponse setBody(QueryRobotPluginResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRobotPluginResponseBody getBody() {
        return this.body;
    }

}
