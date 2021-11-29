// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class DeviceDingResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static DeviceDingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeviceDingResponseBody self = new DeviceDingResponseBody();
        return TeaModel.build(map, self);
    }

    public DeviceDingResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
