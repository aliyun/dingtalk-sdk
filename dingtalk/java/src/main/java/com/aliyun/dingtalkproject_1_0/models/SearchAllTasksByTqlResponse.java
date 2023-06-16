// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchAllTasksByTqlResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SearchAllTasksByTqlResponseBody body;

    public static SearchAllTasksByTqlResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchAllTasksByTqlResponse self = new SearchAllTasksByTqlResponse();
        return TeaModel.build(map, self);
    }

    public SearchAllTasksByTqlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchAllTasksByTqlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchAllTasksByTqlResponse setBody(SearchAllTasksByTqlResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchAllTasksByTqlResponseBody getBody() {
        return this.body;
    }

}
