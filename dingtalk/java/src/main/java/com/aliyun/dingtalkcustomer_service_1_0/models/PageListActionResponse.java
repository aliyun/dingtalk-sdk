// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class PageListActionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public PageListActionResponseBody body;

    public static PageListActionResponse build(java.util.Map<String, ?> map) throws Exception {
        PageListActionResponse self = new PageListActionResponse();
        return TeaModel.build(map, self);
    }

    public PageListActionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PageListActionResponse setBody(PageListActionResponseBody body) {
        this.body = body;
        return this;
    }
    public PageListActionResponseBody getBody() {
        return this.body;
    }

}
