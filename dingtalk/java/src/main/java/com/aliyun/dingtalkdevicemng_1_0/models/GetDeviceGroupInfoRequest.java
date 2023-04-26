// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class GetDeviceGroupInfoRequest extends TeaModel {
    @NameInMap("openConversationId")
    public String openConversationId;

    public static GetDeviceGroupInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDeviceGroupInfoRequest self = new GetDeviceGroupInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetDeviceGroupInfoRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
