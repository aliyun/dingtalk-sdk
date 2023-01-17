// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class SearchConnectorsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public SearchConnectorsResponse setBody(SearchConnectorsResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchConnectorsResponseBody getBody() {
        return this.body;
    }

}
