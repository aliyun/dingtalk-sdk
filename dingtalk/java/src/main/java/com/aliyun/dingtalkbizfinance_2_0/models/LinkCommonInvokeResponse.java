// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class LinkCommonInvokeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public LinkCommonInvokeResponseBody body;

    public static LinkCommonInvokeResponse build(java.util.Map<String, ?> map) throws Exception {
        LinkCommonInvokeResponse self = new LinkCommonInvokeResponse();
        return TeaModel.build(map, self);
    }

    public LinkCommonInvokeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public LinkCommonInvokeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public LinkCommonInvokeResponse setBody(LinkCommonInvokeResponseBody body) {
        this.body = body;
        return this;
    }
    public LinkCommonInvokeResponseBody getBody() {
        return this.body;
    }

}
