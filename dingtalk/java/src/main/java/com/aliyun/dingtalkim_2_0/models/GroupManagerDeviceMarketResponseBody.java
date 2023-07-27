// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0.models;

import com.aliyun.tea.*;

public class GroupManagerDeviceMarketResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static GroupManagerDeviceMarketResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GroupManagerDeviceMarketResponseBody self = new GroupManagerDeviceMarketResponseBody();
        return TeaModel.build(map, self);
    }

    public GroupManagerDeviceMarketResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
