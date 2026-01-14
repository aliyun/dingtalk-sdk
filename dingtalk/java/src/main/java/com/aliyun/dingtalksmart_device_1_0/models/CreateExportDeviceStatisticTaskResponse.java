// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class CreateExportDeviceStatisticTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateExportDeviceStatisticTaskResponseBody body;

    public static CreateExportDeviceStatisticTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateExportDeviceStatisticTaskResponse self = new CreateExportDeviceStatisticTaskResponse();
        return TeaModel.build(map, self);
    }

    public CreateExportDeviceStatisticTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateExportDeviceStatisticTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateExportDeviceStatisticTaskResponse setBody(CreateExportDeviceStatisticTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateExportDeviceStatisticTaskResponseBody getBody() {
        return this.body;
    }

}
