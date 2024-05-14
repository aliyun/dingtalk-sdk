// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetTrustDeviceListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static GetTrustDeviceListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTrustDeviceListRequest self = new GetTrustDeviceListRequest();
        return TeaModel.build(map, self);
    }

    public GetTrustDeviceListRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
