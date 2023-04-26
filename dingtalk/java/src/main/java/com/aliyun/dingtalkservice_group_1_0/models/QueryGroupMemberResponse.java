// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMemberResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryGroupMemberResponseBody body;

    public static QueryGroupMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMemberResponse self = new QueryGroupMemberResponse();
        return TeaModel.build(map, self);
    }

    public QueryGroupMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGroupMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGroupMemberResponse setBody(QueryGroupMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupMemberResponseBody getBody() {
        return this.body;
    }

}
