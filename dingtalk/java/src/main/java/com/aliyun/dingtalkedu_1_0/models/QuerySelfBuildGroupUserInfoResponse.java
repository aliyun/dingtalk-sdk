// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySelfBuildGroupUserInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QuerySelfBuildGroupUserInfoResponseBody body;

    public static QuerySelfBuildGroupUserInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySelfBuildGroupUserInfoResponse self = new QuerySelfBuildGroupUserInfoResponse();
        return TeaModel.build(map, self);
    }

    public QuerySelfBuildGroupUserInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySelfBuildGroupUserInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QuerySelfBuildGroupUserInfoResponse setBody(QuerySelfBuildGroupUserInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySelfBuildGroupUserInfoResponseBody getBody() {
        return this.body;
    }

}
