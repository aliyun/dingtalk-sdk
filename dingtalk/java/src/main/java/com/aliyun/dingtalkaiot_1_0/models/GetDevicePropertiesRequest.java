// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class GetDevicePropertiesRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<String> body;

    public static GetDevicePropertiesRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDevicePropertiesRequest self = new GetDevicePropertiesRequest();
        return TeaModel.build(map, self);
    }

    public GetDevicePropertiesRequest setBody(java.util.List<String> body) {
        this.body = body;
        return this;
    }
    public java.util.List<String> getBody() {
        return this.body;
    }

}
