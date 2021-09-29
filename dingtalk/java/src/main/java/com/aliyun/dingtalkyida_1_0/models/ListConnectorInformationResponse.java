// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListConnectorInformationResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ListConnectorInformationResponse setBody(ListConnectorInformationResponseBody body) {
        this.body = body;
        return this;
    }
    public ListConnectorInformationResponseBody getBody() {
        return this.body;
    }

}
