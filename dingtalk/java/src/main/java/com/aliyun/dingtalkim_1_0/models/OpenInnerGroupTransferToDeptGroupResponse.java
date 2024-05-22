// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenInnerGroupTransferToDeptGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OpenInnerGroupTransferToDeptGroupResponseBody body;

    public static OpenInnerGroupTransferToDeptGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        OpenInnerGroupTransferToDeptGroupResponse self = new OpenInnerGroupTransferToDeptGroupResponse();
        return TeaModel.build(map, self);
    }

    public OpenInnerGroupTransferToDeptGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OpenInnerGroupTransferToDeptGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OpenInnerGroupTransferToDeptGroupResponse setBody(OpenInnerGroupTransferToDeptGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public OpenInnerGroupTransferToDeptGroupResponseBody getBody() {
        return this.body;
    }

}
