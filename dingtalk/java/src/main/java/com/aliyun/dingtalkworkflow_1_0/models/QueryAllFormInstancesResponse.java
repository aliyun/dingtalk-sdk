// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryAllFormInstancesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryAllFormInstancesResponseBody body;

    public static QueryAllFormInstancesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAllFormInstancesResponse self = new QueryAllFormInstancesResponse();
        return TeaModel.build(map, self);
    }

    public QueryAllFormInstancesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAllFormInstancesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAllFormInstancesResponse setBody(QueryAllFormInstancesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAllFormInstancesResponseBody getBody() {
        return this.body;
    }

}
