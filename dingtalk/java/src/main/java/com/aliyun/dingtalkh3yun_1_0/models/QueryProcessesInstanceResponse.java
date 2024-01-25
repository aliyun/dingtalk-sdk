// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class QueryProcessesInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryProcessesInstanceResponseBody body;

    public static QueryProcessesInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryProcessesInstanceResponse self = new QueryProcessesInstanceResponse();
        return TeaModel.build(map, self);
    }

    public QueryProcessesInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryProcessesInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryProcessesInstanceResponse setBody(QueryProcessesInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryProcessesInstanceResponseBody getBody() {
        return this.body;
    }

}
