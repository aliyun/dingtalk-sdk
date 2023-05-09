// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class SearchDentriesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SearchDentriesResponseBody body;

    public static SearchDentriesResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchDentriesResponse self = new SearchDentriesResponse();
        return TeaModel.build(map, self);
    }

    public SearchDentriesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchDentriesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchDentriesResponse setBody(SearchDentriesResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchDentriesResponseBody getBody() {
        return this.body;
    }

}
