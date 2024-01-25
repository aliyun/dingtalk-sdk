// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryUserManagementResourcesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUserManagementResourcesResponseBody body;

    public static QueryUserManagementResourcesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserManagementResourcesResponse self = new QueryUserManagementResourcesResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserManagementResourcesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserManagementResourcesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserManagementResourcesResponse setBody(QueryUserManagementResourcesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserManagementResourcesResponseBody getBody() {
        return this.body;
    }

}
