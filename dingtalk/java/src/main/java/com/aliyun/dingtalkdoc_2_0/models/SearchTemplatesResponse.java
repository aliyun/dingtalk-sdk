// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SearchTemplatesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchTemplatesResponseBody body;

    public static SearchTemplatesResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchTemplatesResponse self = new SearchTemplatesResponse();
        return TeaModel.build(map, self);
    }

    public SearchTemplatesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchTemplatesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchTemplatesResponse setBody(SearchTemplatesResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchTemplatesResponseBody getBody() {
        return this.body;
    }

}
