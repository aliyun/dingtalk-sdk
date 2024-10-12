// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class QueryTasksV3Response extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryTasksV3ResponseBody body;

    public static QueryTasksV3Response build(java.util.Map<String, ?> map) throws Exception {
        QueryTasksV3Response self = new QueryTasksV3Response();
        return TeaModel.build(map, self);
    }

    public QueryTasksV3Response setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTasksV3Response setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryTasksV3Response setBody(QueryTasksV3ResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTasksV3ResponseBody getBody() {
        return this.body;
    }

}
