// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivateStoreCapacityUsageResponseBody extends TeaModel {
    @NameInMap("usedSize")
    public Long usedSize;

    public static GetPrivateStoreCapacityUsageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPrivateStoreCapacityUsageResponseBody self = new GetPrivateStoreCapacityUsageResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPrivateStoreCapacityUsageResponseBody setUsedSize(Long usedSize) {
        this.usedSize = usedSize;
        return this;
    }
    public Long getUsedSize() {
        return this.usedSize;
    }

}
