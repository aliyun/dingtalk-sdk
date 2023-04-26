// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class PageInnerAppHistoryVersionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public PageInnerAppHistoryVersionResponseBody body;

    public static PageInnerAppHistoryVersionResponse build(java.util.Map<String, ?> map) throws Exception {
        PageInnerAppHistoryVersionResponse self = new PageInnerAppHistoryVersionResponse();
        return TeaModel.build(map, self);
    }

    public PageInnerAppHistoryVersionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PageInnerAppHistoryVersionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PageInnerAppHistoryVersionResponse setBody(PageInnerAppHistoryVersionResponseBody body) {
        this.body = body;
        return this;
    }
    public PageInnerAppHistoryVersionResponseBody getBody() {
        return this.body;
    }

}
