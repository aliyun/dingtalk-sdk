// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class IsFriendRequest extends TeaModel {
    // 手机号码
    @NameInMap("mobileNo")
    public String mobileNo;

    // 工号
    @NameInMap("userId")
    public String userId;

    public static IsFriendRequest build(java.util.Map<String, ?> map) throws Exception {
        IsFriendRequest self = new IsFriendRequest();
        return TeaModel.build(map, self);
    }

    public IsFriendRequest setMobileNo(String mobileNo) {
        this.mobileNo = mobileNo;
        return this;
    }
    public String getMobileNo() {
        return this.mobileNo;
    }

    public IsFriendRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
