// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryRelationDatasByTargetIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryRelationDatasByTargetIdResponseBody body;

    public static QueryRelationDatasByTargetIdResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryRelationDatasByTargetIdResponse self = new QueryRelationDatasByTargetIdResponse();
        return TeaModel.build(map, self);
    }

    public QueryRelationDatasByTargetIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryRelationDatasByTargetIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryRelationDatasByTargetIdResponse setBody(QueryRelationDatasByTargetIdResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRelationDatasByTargetIdResponseBody getBody() {
        return this.body;
    }

}
