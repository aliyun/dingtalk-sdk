// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class AddDeviceVideoConferenceMembersRequest extends TeaModel {
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static AddDeviceVideoConferenceMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        AddDeviceVideoConferenceMembersRequest self = new AddDeviceVideoConferenceMembersRequest();
        return TeaModel.build(map, self);
    }

    public AddDeviceVideoConferenceMembersRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
