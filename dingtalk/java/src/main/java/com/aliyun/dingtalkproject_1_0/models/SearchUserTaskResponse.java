// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchUserTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchUserTaskResponseBody body;

    public static SearchUserTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchUserTaskResponse self = new SearchUserTaskResponse();
        return TeaModel.build(map, self);
    }

    public SearchUserTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchUserTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchUserTaskResponse setBody(SearchUserTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchUserTaskResponseBody getBody() {
        return this.body;
    }

}
