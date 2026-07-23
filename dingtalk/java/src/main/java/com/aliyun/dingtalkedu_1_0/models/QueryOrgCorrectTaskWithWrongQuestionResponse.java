// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgCorrectTaskWithWrongQuestionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryOrgCorrectTaskWithWrongQuestionResponseBody body;

    public static QueryOrgCorrectTaskWithWrongQuestionResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgCorrectTaskWithWrongQuestionResponse self = new QueryOrgCorrectTaskWithWrongQuestionResponse();
        return TeaModel.build(map, self);
    }

    public QueryOrgCorrectTaskWithWrongQuestionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOrgCorrectTaskWithWrongQuestionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryOrgCorrectTaskWithWrongQuestionResponse setBody(QueryOrgCorrectTaskWithWrongQuestionResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOrgCorrectTaskWithWrongQuestionResponseBody getBody() {
        return this.body;
    }

}
