// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class SearchActionsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchActionsResponseBody body;

    public static SearchActionsResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchActionsResponse self = new SearchActionsResponse();
        return TeaModel.build(map, self);
    }

    public SearchActionsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchActionsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchActionsResponse setBody(SearchActionsResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchActionsResponseBody getBody() {
        return this.body;
    }

}
