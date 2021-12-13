// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class QueryAppFunctionNodesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryAppFunctionNodesResponse setBody(QueryAppFunctionNodesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAppFunctionNodesResponseBody getBody() {
        return this.body;
    }

}
