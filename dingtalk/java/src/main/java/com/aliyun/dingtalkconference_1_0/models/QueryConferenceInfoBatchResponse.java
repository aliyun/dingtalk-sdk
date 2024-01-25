// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryConferenceInfoBatchResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryConferenceInfoBatchResponseBody body;

    public static QueryConferenceInfoBatchResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryConferenceInfoBatchResponse self = new QueryConferenceInfoBatchResponse();
        return TeaModel.build(map, self);
    }

    public QueryConferenceInfoBatchResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryConferenceInfoBatchResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryConferenceInfoBatchResponse setBody(QueryConferenceInfoBatchResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryConferenceInfoBatchResponseBody getBody() {
        return this.body;
    }

}
