// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListApplicationInformationResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListApplicationInformationResponseBody body;

    public static ListApplicationInformationResponse build(java.util.Map<String, ?> map) throws Exception {
        ListApplicationInformationResponse self = new ListApplicationInformationResponse();
        return TeaModel.build(map, self);
    }

    public ListApplicationInformationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListApplicationInformationResponse setBody(ListApplicationInformationResponseBody body) {
        this.body = body;
        return this;
    }
    public ListApplicationInformationResponseBody getBody() {
        return this.body;
    }

}
