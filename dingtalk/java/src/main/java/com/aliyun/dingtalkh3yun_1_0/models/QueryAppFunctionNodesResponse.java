// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class QueryAppFunctionNodesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryAppFunctionNodesResponseBody body;

    public static QueryAppFunctionNodesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAppFunctionNodesResponse self = new QueryAppFunctionNodesResponse();
        return TeaModel.build(map, self);
    }

    public QueryAppFunctionNodesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAppFunctionNodesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAppFunctionNodesResponse setBody(QueryAppFunctionNodesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAppFunctionNodesResponseBody getBody() {
        return this.body;
    }

}
