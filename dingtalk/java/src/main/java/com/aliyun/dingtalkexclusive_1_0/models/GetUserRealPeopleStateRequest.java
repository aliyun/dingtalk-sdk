// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetUserRealPeopleStateRequest extends TeaModel {
    /**
     * <p>userIds</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static GetUserRealPeopleStateRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserRealPeopleStateRequest self = new GetUserRealPeopleStateRequest();
        return TeaModel.build(map, self);
    }

    public GetUserRealPeopleStateRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
