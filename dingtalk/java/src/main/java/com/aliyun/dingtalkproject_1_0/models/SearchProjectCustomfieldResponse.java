// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectCustomfieldResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchProjectCustomfieldResponseBody body;

    public static SearchProjectCustomfieldResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchProjectCustomfieldResponse self = new SearchProjectCustomfieldResponse();
        return TeaModel.build(map, self);
    }

    public SearchProjectCustomfieldResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchProjectCustomfieldResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchProjectCustomfieldResponse setBody(SearchProjectCustomfieldResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchProjectCustomfieldResponseBody getBody() {
        return this.body;
    }

}
