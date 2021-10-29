// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgRelationListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryOrgRelationListResponse setBody(QueryOrgRelationListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOrgRelationListResponseBody getBody() {
        return this.body;
    }

}
