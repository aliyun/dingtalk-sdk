// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class CreateDeviceVideoConferenceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static CreateDeviceVideoConferenceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateDeviceVideoConferenceRequest self = new CreateDeviceVideoConferenceRequest();
        return TeaModel.build(map, self);
    }

    public CreateDeviceVideoConferenceRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
