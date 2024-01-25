// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryAllProcessInstancesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryAllProcessInstancesResponseBody body;

    public static QueryAllProcessInstancesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAllProcessInstancesResponse self = new QueryAllProcessInstancesResponse();
        return TeaModel.build(map, self);
    }

    public QueryAllProcessInstancesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAllProcessInstancesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAllProcessInstancesResponse setBody(QueryAllProcessInstancesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAllProcessInstancesResponseBody getBody() {
        return this.body;
    }

}
