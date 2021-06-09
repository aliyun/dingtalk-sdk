// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryConferenceInfoBatchResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryConferenceInfoBatchResponse setBody(QueryConferenceInfoBatchResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryConferenceInfoBatchResponseBody getBody() {
        return this.body;
    }

}
