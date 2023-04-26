// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchTaskflowStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SearchTaskflowStatusResponseBody body;

    public static SearchTaskflowStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchTaskflowStatusResponse self = new SearchTaskflowStatusResponse();
        return TeaModel.build(map, self);
    }

    public SearchTaskflowStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchTaskflowStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchTaskflowStatusResponse setBody(SearchTaskflowStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchTaskflowStatusResponseBody getBody() {
        return this.body;
    }

}
