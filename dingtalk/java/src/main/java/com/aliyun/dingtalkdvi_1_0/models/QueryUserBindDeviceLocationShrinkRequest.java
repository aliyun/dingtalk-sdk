// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryUserBindDeviceLocationShrinkRequest extends TeaModel {
    @NameInMap("userIdList")
    public String userIdListShrink;

    public static QueryUserBindDeviceLocationShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUserBindDeviceLocationShrinkRequest self = new QueryUserBindDeviceLocationShrinkRequest();
        return TeaModel.build(map, self);
    }

    public QueryUserBindDeviceLocationShrinkRequest setUserIdListShrink(String userIdListShrink) {
        this.userIdListShrink = userIdListShrink;
        return this;
    }
    public String getUserIdListShrink() {
        return this.userIdListShrink;
    }

}
