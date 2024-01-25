// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomEntryProcessesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCustomEntryProcessesResponseBody body;

    public static QueryCustomEntryProcessesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomEntryProcessesResponse self = new QueryCustomEntryProcessesResponse();
        return TeaModel.build(map, self);
    }

    public QueryCustomEntryProcessesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCustomEntryProcessesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCustomEntryProcessesResponse setBody(QueryCustomEntryProcessesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCustomEntryProcessesResponseBody getBody() {
        return this.body;
    }

}
