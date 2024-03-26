// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportLabelInventoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportLabelInventoryResponseBody body;

    public static HrbrainImportLabelInventoryResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportLabelInventoryResponse self = new HrbrainImportLabelInventoryResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportLabelInventoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportLabelInventoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportLabelInventoryResponse setBody(HrbrainImportLabelInventoryResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportLabelInventoryResponseBody getBody() {
        return this.body;
    }

}
