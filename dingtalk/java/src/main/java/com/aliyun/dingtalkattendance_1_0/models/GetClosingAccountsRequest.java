// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetClosingAccountsRequest extends TeaModel {
    // 人员列表
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static GetClosingAccountsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetClosingAccountsRequest self = new GetClosingAccountsRequest();
        return TeaModel.build(map, self);
    }

    public GetClosingAccountsRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
