// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class SearchPublishDentriesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchPublishDentriesResponseBody body;

    public static SearchPublishDentriesResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchPublishDentriesResponse self = new SearchPublishDentriesResponse();
        return TeaModel.build(map, self);
    }

    public SearchPublishDentriesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchPublishDentriesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchPublishDentriesResponse setBody(SearchPublishDentriesResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchPublishDentriesResponseBody getBody() {
        return this.body;
    }

}
