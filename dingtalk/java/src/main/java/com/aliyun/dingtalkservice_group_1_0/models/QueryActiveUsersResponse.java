// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryActiveUsersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryActiveUsersResponseBody body;

    public static QueryActiveUsersResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryActiveUsersResponse self = new QueryActiveUsersResponse();
        return TeaModel.build(map, self);
    }

    public QueryActiveUsersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryActiveUsersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryActiveUsersResponse setBody(QueryActiveUsersResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryActiveUsersResponseBody getBody() {
        return this.body;
    }

}
