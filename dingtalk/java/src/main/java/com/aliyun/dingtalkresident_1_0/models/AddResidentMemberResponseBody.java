// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddResidentMemberResponseBody extends TeaModel {
    // userId
    @NameInMap("userId")
    public String userId;

    public static AddResidentMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddResidentMemberResponseBody self = new AddResidentMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public AddResidentMemberResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
