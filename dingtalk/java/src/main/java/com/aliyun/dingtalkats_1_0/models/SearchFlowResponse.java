// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class SearchFlowResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchFlowResponseBody body;

    public static SearchFlowResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchFlowResponse self = new SearchFlowResponse();
        return TeaModel.build(map, self);
    }

    public SearchFlowResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchFlowResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchFlowResponse setBody(SearchFlowResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchFlowResponseBody getBody() {
        return this.body;
    }

}
