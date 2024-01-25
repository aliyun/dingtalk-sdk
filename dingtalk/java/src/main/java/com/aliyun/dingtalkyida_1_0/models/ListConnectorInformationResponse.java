// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListConnectorInformationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListConnectorInformationResponseBody body;

    public static ListConnectorInformationResponse build(java.util.Map<String, ?> map) throws Exception {
        ListConnectorInformationResponse self = new ListConnectorInformationResponse();
        return TeaModel.build(map, self);
    }

    public ListConnectorInformationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListConnectorInformationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListConnectorInformationResponse setBody(ListConnectorInformationResponseBody body) {
        this.body = body;
        return this;
    }
    public ListConnectorInformationResponseBody getBody() {
        return this.body;
    }

}
