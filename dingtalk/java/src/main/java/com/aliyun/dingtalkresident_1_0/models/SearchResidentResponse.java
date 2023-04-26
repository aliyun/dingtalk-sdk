// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class SearchResidentResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SearchResidentResponseBody body;

    public static SearchResidentResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchResidentResponse self = new SearchResidentResponse();
        return TeaModel.build(map, self);
    }

    public SearchResidentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchResidentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchResidentResponse setBody(SearchResidentResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchResidentResponseBody getBody() {
        return this.body;
    }

}
