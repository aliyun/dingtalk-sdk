// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class RemoveDeviceResponseBody extends TeaModel {
    // 返回结果
    @NameInMap("success")
    public String success;

    public static RemoveDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveDeviceResponseBody self = new RemoveDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveDeviceResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
