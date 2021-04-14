// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class KickDeviceVideoConferenceMembersRequest extends TeaModel {
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static KickDeviceVideoConferenceMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        KickDeviceVideoConferenceMembersRequest self = new KickDeviceVideoConferenceMembersRequest();
        return TeaModel.build(map, self);
    }

    public KickDeviceVideoConferenceMembersRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
