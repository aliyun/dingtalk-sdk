// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryAllProcessInstancesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryAllProcessInstancesResponse setBody(QueryAllProcessInstancesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAllProcessInstancesResponseBody getBody() {
        return this.body;
    }

}
