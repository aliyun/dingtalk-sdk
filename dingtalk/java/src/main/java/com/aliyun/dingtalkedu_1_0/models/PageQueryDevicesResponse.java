// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PageQueryDevicesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PageQueryDevicesResponseBody body;

    public static PageQueryDevicesResponse build(java.util.Map<String, ?> map) throws Exception {
        PageQueryDevicesResponse self = new PageQueryDevicesResponse();
        return TeaModel.build(map, self);
    }

    public PageQueryDevicesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PageQueryDevicesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PageQueryDevicesResponse setBody(PageQueryDevicesResponseBody body) {
        this.body = body;
        return this;
    }
    public PageQueryDevicesResponseBody getBody() {
        return this.body;
    }

}
