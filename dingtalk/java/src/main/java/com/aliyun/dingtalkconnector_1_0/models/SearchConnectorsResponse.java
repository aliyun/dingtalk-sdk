// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class SearchConnectorsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchConnectorsResponseBody body;

    public static SearchConnectorsResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchConnectorsResponse self = new SearchConnectorsResponse();
        return TeaModel.build(map, self);
    }

    public SearchConnectorsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchConnectorsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchConnectorsResponse setBody(SearchConnectorsResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchConnectorsResponseBody getBody() {
        return this.body;
    }

}
