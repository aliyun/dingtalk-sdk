// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class GetKnowledgeListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetKnowledgeListResponseBody body;

    public static GetKnowledgeListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetKnowledgeListResponse self = new GetKnowledgeListResponse();
        return TeaModel.build(map, self);
    }

    public GetKnowledgeListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetKnowledgeListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetKnowledgeListResponse setBody(GetKnowledgeListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetKnowledgeListResponseBody getBody() {
        return this.body;
    }

}
