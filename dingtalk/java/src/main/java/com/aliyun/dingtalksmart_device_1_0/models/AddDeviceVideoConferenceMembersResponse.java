// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class AddDeviceVideoConferenceMembersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static AddDeviceVideoConferenceMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        AddDeviceVideoConferenceMembersResponse self = new AddDeviceVideoConferenceMembersResponse();
        return TeaModel.build(map, self);
    }

    public AddDeviceVideoConferenceMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
