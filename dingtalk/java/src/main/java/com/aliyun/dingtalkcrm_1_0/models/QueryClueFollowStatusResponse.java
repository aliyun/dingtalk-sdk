// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryClueFollowStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryClueFollowStatusResponseBody body;

    public static QueryClueFollowStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryClueFollowStatusResponse self = new QueryClueFollowStatusResponse();
        return TeaModel.build(map, self);
    }

    public QueryClueFollowStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryClueFollowStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryClueFollowStatusResponse setBody(QueryClueFollowStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryClueFollowStatusResponseBody getBody() {
        return this.body;
    }

}
