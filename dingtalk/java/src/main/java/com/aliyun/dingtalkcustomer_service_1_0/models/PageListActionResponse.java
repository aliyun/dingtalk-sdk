// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class PageListActionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public PageListActionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PageListActionResponse setBody(PageListActionResponseBody body) {
        this.body = body;
        return this;
    }
    public PageListActionResponseBody getBody() {
        return this.body;
    }

}
