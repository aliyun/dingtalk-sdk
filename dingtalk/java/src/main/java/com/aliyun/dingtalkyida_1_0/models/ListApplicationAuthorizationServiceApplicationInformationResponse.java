// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListApplicationAuthorizationServiceApplicationInformationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListApplicationAuthorizationServiceApplicationInformationResponseBody body;

    public static ListApplicationAuthorizationServiceApplicationInformationResponse build(java.util.Map<String, ?> map) throws Exception {
        ListApplicationAuthorizationServiceApplicationInformationResponse self = new ListApplicationAuthorizationServiceApplicationInformationResponse();
        return TeaModel.build(map, self);
    }

    public ListApplicationAuthorizationServiceApplicationInformationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListApplicationAuthorizationServiceApplicationInformationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListApplicationAuthorizationServiceApplicationInformationResponse setBody(ListApplicationAuthorizationServiceApplicationInformationResponseBody body) {
        this.body = body;
        return this;
    }
    public ListApplicationAuthorizationServiceApplicationInformationResponseBody getBody() {
        return this.body;
    }

}
