// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryResourceManagementMembersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryResourceManagementMembersResponseBody body;

    public static QueryResourceManagementMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryResourceManagementMembersResponse self = new QueryResourceManagementMembersResponse();
        return TeaModel.build(map, self);
    }

    public QueryResourceManagementMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryResourceManagementMembersResponse setBody(QueryResourceManagementMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryResourceManagementMembersResponseBody getBody() {
        return this.body;
    }

}
