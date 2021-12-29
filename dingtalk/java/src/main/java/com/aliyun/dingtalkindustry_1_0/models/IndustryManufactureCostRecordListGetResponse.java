// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureCostRecordListGetResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public IndustryManufactureCostRecordListGetResponse setBody(IndustryManufactureCostRecordListGetResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureCostRecordListGetResponseBody getBody() {
        return this.body;
    }

}
