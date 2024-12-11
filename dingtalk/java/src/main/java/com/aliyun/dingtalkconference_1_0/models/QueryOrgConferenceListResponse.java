// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgConferenceListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryOrgConferenceListResponseBody body;

    public static QueryOrgConferenceListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgConferenceListResponse self = new QueryOrgConferenceListResponse();
        return TeaModel.build(map, self);
    }

    public QueryOrgConferenceListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOrgConferenceListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryOrgConferenceListResponse setBody(QueryOrgConferenceListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOrgConferenceListResponseBody getBody() {
        return this.body;
    }

}
