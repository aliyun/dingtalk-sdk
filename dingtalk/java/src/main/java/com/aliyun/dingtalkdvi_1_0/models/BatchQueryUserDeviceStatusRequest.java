// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryUserDeviceStatusRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static BatchQueryUserDeviceStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryUserDeviceStatusRequest self = new BatchQueryUserDeviceStatusRequest();
        return TeaModel.build(map, self);
    }

    public BatchQueryUserDeviceStatusRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
