// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditGoodsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EditGoodsResponseBody body;

    public static EditGoodsResponse build(java.util.Map<String, ?> map) throws Exception {
        EditGoodsResponse self = new EditGoodsResponse();
        return TeaModel.build(map, self);
    }

    public EditGoodsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditGoodsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EditGoodsResponse setBody(EditGoodsResponseBody body) {
        this.body = body;
        return this;
    }
    public EditGoodsResponseBody getBody() {
        return this.body;
    }

}
