// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceGroupMessageReadStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryServiceGroupMessageReadStatusResponseBody body;

    public static QueryServiceGroupMessageReadStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryServiceGroupMessageReadStatusResponse self = new QueryServiceGroupMessageReadStatusResponse();
        return TeaModel.build(map, self);
    }

    public QueryServiceGroupMessageReadStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryServiceGroupMessageReadStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryServiceGroupMessageReadStatusResponse setBody(QueryServiceGroupMessageReadStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryServiceGroupMessageReadStatusResponseBody getBody() {
        return this.body;
    }

}
