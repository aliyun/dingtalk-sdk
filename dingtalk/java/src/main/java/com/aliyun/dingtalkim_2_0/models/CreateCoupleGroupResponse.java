// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0.models;

import com.aliyun.tea.*;

public class CreateCoupleGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateCoupleGroupResponseBody body;

    public static CreateCoupleGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateCoupleGroupResponse self = new CreateCoupleGroupResponse();
        return TeaModel.build(map, self);
    }

    public CreateCoupleGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateCoupleGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateCoupleGroupResponse setBody(CreateCoupleGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCoupleGroupResponseBody getBody() {
        return this.body;
    }

}
