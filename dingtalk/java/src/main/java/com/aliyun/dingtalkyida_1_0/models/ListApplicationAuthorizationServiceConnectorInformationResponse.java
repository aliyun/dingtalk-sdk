// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListApplicationAuthorizationServiceConnectorInformationResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ListApplicationAuthorizationServiceConnectorInformationResponse setBody(ListApplicationAuthorizationServiceConnectorInformationResponseBody body) {
        this.body = body;
        return this;
    }
    public ListApplicationAuthorizationServiceConnectorInformationResponseBody getBody() {
        return this.body;
    }

}
