// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryInnerGroupMemberListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryInnerGroupMemberListResponseBody body;

    public static QueryInnerGroupMemberListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryInnerGroupMemberListResponse self = new QueryInnerGroupMemberListResponse();
        return TeaModel.build(map, self);
    }

    public QueryInnerGroupMemberListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryInnerGroupMemberListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryInnerGroupMemberListResponse setBody(QueryInnerGroupMemberListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryInnerGroupMemberListResponseBody getBody() {
        return this.body;
    }

}
