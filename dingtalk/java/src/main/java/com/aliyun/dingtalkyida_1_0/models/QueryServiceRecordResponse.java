// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceRecordResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryServiceRecordResponseBody body;

    public static QueryServiceRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryServiceRecordResponse self = new QueryServiceRecordResponse();
        return TeaModel.build(map, self);
    }

    public QueryServiceRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryServiceRecordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryServiceRecordResponse setBody(QueryServiceRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryServiceRecordResponseBody getBody() {
        return this.body;
    }

}
