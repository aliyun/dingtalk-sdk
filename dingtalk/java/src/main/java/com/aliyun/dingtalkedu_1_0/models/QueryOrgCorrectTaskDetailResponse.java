// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgCorrectTaskDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryOrgCorrectTaskDetailResponseBody body;

    public static QueryOrgCorrectTaskDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgCorrectTaskDetailResponse self = new QueryOrgCorrectTaskDetailResponse();
        return TeaModel.build(map, self);
    }

    public QueryOrgCorrectTaskDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOrgCorrectTaskDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryOrgCorrectTaskDetailResponse setBody(QueryOrgCorrectTaskDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOrgCorrectTaskDetailResponseBody getBody() {
        return this.body;
    }

}
