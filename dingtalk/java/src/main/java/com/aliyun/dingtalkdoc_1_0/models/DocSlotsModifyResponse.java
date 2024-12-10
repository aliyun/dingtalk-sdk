// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocSlotsModifyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DocSlotsModifyResponseBody body;

    public static DocSlotsModifyResponse build(java.util.Map<String, ?> map) throws Exception {
        DocSlotsModifyResponse self = new DocSlotsModifyResponse();
        return TeaModel.build(map, self);
    }

    public DocSlotsModifyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DocSlotsModifyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DocSlotsModifyResponse setBody(DocSlotsModifyResponseBody body) {
        this.body = body;
        return this;
    }
    public DocSlotsModifyResponseBody getBody() {
        return this.body;
    }

}
