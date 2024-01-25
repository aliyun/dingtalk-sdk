// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureCostRecordListGetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public IndustryManufactureCostRecordListGetResponseBody body;

    public static IndustryManufactureCostRecordListGetResponse build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureCostRecordListGetResponse self = new IndustryManufactureCostRecordListGetResponse();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureCostRecordListGetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IndustryManufactureCostRecordListGetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IndustryManufactureCostRecordListGetResponse setBody(IndustryManufactureCostRecordListGetResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureCostRecordListGetResponseBody getBody() {
        return this.body;
    }

}
