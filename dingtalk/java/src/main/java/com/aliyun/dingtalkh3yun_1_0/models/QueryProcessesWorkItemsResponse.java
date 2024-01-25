// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class QueryProcessesWorkItemsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryProcessesWorkItemsResponseBody body;

    public static QueryProcessesWorkItemsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryProcessesWorkItemsResponse self = new QueryProcessesWorkItemsResponse();
        return TeaModel.build(map, self);
    }

    public QueryProcessesWorkItemsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryProcessesWorkItemsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryProcessesWorkItemsResponse setBody(QueryProcessesWorkItemsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryProcessesWorkItemsResponseBody getBody() {
        return this.body;
    }

}
