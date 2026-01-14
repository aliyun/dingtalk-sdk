// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class UpdateExportDeviceStatisticResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateExportDeviceStatisticResponseBody body;

    public static UpdateExportDeviceStatisticResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateExportDeviceStatisticResponse self = new UpdateExportDeviceStatisticResponse();
        return TeaModel.build(map, self);
    }

    public UpdateExportDeviceStatisticResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateExportDeviceStatisticResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateExportDeviceStatisticResponse setBody(UpdateExportDeviceStatisticResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateExportDeviceStatisticResponseBody getBody() {
        return this.body;
    }

}
