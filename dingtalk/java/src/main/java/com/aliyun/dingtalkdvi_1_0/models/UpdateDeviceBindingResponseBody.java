// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class UpdateDeviceBindingResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateDeviceBindingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateDeviceBindingResponseBody self = new UpdateDeviceBindingResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateDeviceBindingResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
