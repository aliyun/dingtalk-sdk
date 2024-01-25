// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchTaskListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchTaskListResponseBody body;

    public static SearchTaskListResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchTaskListResponse self = new SearchTaskListResponse();
        return TeaModel.build(map, self);
    }

    public SearchTaskListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchTaskListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchTaskListResponse setBody(SearchTaskListResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchTaskListResponseBody getBody() {
        return this.body;
    }

}
