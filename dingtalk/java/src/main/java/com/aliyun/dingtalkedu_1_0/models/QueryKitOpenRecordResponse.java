// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryKitOpenRecordResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryKitOpenRecordResponseBody body;

    public static QueryKitOpenRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryKitOpenRecordResponse self = new QueryKitOpenRecordResponse();
        return TeaModel.build(map, self);
    }

    public QueryKitOpenRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryKitOpenRecordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryKitOpenRecordResponse setBody(QueryKitOpenRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryKitOpenRecordResponseBody getBody() {
        return this.body;
    }

}
