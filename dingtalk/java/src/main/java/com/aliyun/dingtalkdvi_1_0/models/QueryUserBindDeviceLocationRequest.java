// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryUserBindDeviceLocationRequest extends TeaModel {
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static QueryUserBindDeviceLocationRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUserBindDeviceLocationRequest self = new QueryUserBindDeviceLocationRequest();
        return TeaModel.build(map, self);
    }

    public QueryUserBindDeviceLocationRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
