// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class SearchAllTasksByTqlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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
