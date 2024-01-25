// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QuerySceneGroupTemplateRobotResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QuerySceneGroupTemplateRobotResponseBody body;

    public static QuerySceneGroupTemplateRobotResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySceneGroupTemplateRobotResponse self = new QuerySceneGroupTemplateRobotResponse();
        return TeaModel.build(map, self);
    }

    public QuerySceneGroupTemplateRobotResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySceneGroupTemplateRobotResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QuerySceneGroupTemplateRobotResponse setBody(QuerySceneGroupTemplateRobotResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySceneGroupTemplateRobotResponseBody getBody() {
        return this.body;
    }

}
