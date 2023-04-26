// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class ListAvaiableVersionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListAvaiableVersionResponseBody body;

    public static ListAvaiableVersionResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAvaiableVersionResponse self = new ListAvaiableVersionResponse();
        return TeaModel.build(map, self);
    }

    public ListAvaiableVersionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAvaiableVersionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListAvaiableVersionResponse setBody(ListAvaiableVersionResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAvaiableVersionResponseBody getBody() {
        return this.body;
    }

}
