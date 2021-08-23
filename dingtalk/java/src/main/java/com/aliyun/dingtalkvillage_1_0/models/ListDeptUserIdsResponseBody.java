// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListDeptUserIdsResponseBody extends TeaModel {
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static ListDeptUserIdsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListDeptUserIdsResponseBody self = new ListDeptUserIdsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListDeptUserIdsResponseBody setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
