// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchOranizationCustomfieldResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchOranizationCustomfieldResponseBody body;

    public static SearchOranizationCustomfieldResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchOranizationCustomfieldResponse self = new SearchOranizationCustomfieldResponse();
        return TeaModel.build(map, self);
    }

    public SearchOranizationCustomfieldResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchOranizationCustomfieldResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchOranizationCustomfieldResponse setBody(SearchOranizationCustomfieldResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchOranizationCustomfieldResponseBody getBody() {
        return this.body;
    }

}
