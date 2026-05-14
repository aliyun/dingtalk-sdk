// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class QueryChangedRecordIdsByClientTokenResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryChangedRecordIdsByClientTokenResponseBody body;

    public static QueryChangedRecordIdsByClientTokenResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryChangedRecordIdsByClientTokenResponse self = new QueryChangedRecordIdsByClientTokenResponse();
        return TeaModel.build(map, self);
    }

    public QueryChangedRecordIdsByClientTokenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryChangedRecordIdsByClientTokenResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryChangedRecordIdsByClientTokenResponse setBody(QueryChangedRecordIdsByClientTokenResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryChangedRecordIdsByClientTokenResponseBody getBody() {
        return this.body;
    }

}
