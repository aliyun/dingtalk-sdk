// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceRecordLocationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryServiceRecordLocationResponseBody body;

    public static QueryServiceRecordLocationResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryServiceRecordLocationResponse self = new QueryServiceRecordLocationResponse();
        return TeaModel.build(map, self);
    }

    public QueryServiceRecordLocationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryServiceRecordLocationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryServiceRecordLocationResponse setBody(QueryServiceRecordLocationResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryServiceRecordLocationResponseBody getBody() {
        return this.body;
    }

}
