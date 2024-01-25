// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ModifyOrgAccUserOwnnessResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ModifyOrgAccUserOwnnessResponseBody body;

    public static ModifyOrgAccUserOwnnessResponse build(java.util.Map<String, ?> map) throws Exception {
        ModifyOrgAccUserOwnnessResponse self = new ModifyOrgAccUserOwnnessResponse();
        return TeaModel.build(map, self);
    }

    public ModifyOrgAccUserOwnnessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ModifyOrgAccUserOwnnessResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ModifyOrgAccUserOwnnessResponse setBody(ModifyOrgAccUserOwnnessResponseBody body) {
        this.body = body;
        return this;
    }
    public ModifyOrgAccUserOwnnessResponseBody getBody() {
        return this.body;
    }

}
