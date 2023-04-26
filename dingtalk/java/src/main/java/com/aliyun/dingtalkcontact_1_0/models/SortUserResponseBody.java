// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SortUserResponseBody extends TeaModel {
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static SortUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SortUserResponseBody self = new SortUserResponseBody();
        return TeaModel.build(map, self);
    }

    public SortUserResponseBody setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
