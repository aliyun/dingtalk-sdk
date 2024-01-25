// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgRelationListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryOrgRelationListResponseBody body;

    public static QueryOrgRelationListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgRelationListResponse self = new QueryOrgRelationListResponse();
        return TeaModel.build(map, self);
    }

    public QueryOrgRelationListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOrgRelationListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryOrgRelationListResponse setBody(QueryOrgRelationListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOrgRelationListResponseBody getBody() {
        return this.body;
    }

}
