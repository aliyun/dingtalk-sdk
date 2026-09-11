// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class RemoveUserFaceRequest extends TeaModel {
    @NameInMap("userId")
    public String userId;

    public static RemoveUserFaceRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveUserFaceRequest self = new RemoveUserFaceRequest();
        return TeaModel.build(map, self);
    }

    public RemoveUserFaceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
