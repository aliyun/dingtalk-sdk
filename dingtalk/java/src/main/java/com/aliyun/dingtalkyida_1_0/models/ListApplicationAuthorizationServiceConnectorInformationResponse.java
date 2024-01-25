// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListApplicationAuthorizationServiceConnectorInformationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListApplicationAuthorizationServiceConnectorInformationResponseBody body;

    public static ListApplicationAuthorizationServiceConnectorInformationResponse build(java.util.Map<String, ?> map) throws Exception {
        ListApplicationAuthorizationServiceConnectorInformationResponse self = new ListApplicationAuthorizationServiceConnectorInformationResponse();
        return TeaModel.build(map, self);
    }

    public ListApplicationAuthorizationServiceConnectorInformationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListApplicationAuthorizationServiceConnectorInformationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListApplicationAuthorizationServiceConnectorInformationResponse setBody(ListApplicationAuthorizationServiceConnectorInformationResponseBody body) {
        this.body = body;
        return this;
    }
    public ListApplicationAuthorizationServiceConnectorInformationResponseBody getBody() {
        return this.body;
    }

}
