// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchTaskFlowResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchTaskFlowResponseBody body;

    public static SearchTaskFlowResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchTaskFlowResponse self = new SearchTaskFlowResponse();
        return TeaModel.build(map, self);
    }

    public SearchTaskFlowResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchTaskFlowResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchTaskFlowResponse setBody(SearchTaskFlowResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchTaskFlowResponseBody getBody() {
        return this.body;
    }

}
