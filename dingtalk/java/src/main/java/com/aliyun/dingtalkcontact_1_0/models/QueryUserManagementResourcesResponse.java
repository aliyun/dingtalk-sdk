// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryUserManagementResourcesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryUserManagementResourcesResponse setBody(QueryUserManagementResourcesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserManagementResourcesResponseBody getBody() {
        return this.body;
    }

}
