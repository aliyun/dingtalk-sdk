// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateRemoteClassDeviceResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("success")
    public Boolean success;

    public static UpdateRemoteClassDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateRemoteClassDeviceResponseBody self = new UpdateRemoteClassDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateRemoteClassDeviceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
