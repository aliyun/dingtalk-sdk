// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetUserFaceStateRequest extends TeaModel {
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static GetUserFaceStateRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserFaceStateRequest self = new GetUserFaceStateRequest();
        return TeaModel.build(map, self);
    }

    public GetUserFaceStateRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
