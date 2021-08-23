// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListResidentUserInfosResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListResidentUserInfosResponseBody body;

    public static ListResidentUserInfosResponse build(java.util.Map<String, ?> map) throws Exception {
        ListResidentUserInfosResponse self = new ListResidentUserInfosResponse();
        return TeaModel.build(map, self);
    }

    public ListResidentUserInfosResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListResidentUserInfosResponse setBody(ListResidentUserInfosResponseBody body) {
        this.body = body;
        return this;
    }
    public ListResidentUserInfosResponseBody getBody() {
        return this.body;
    }

}
