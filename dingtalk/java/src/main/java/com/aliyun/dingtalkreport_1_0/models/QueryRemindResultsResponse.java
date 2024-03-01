// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkreport_1_0.models;

import com.aliyun.tea.*;

public class QueryRemindResultsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryRemindResultsResponseBody body;

    public static QueryRemindResultsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryRemindResultsResponse self = new QueryRemindResultsResponse();
        return TeaModel.build(map, self);
    }

    public QueryRemindResultsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryRemindResultsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryRemindResultsResponse setBody(QueryRemindResultsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRemindResultsResponseBody getBody() {
        return this.body;
    }

}
