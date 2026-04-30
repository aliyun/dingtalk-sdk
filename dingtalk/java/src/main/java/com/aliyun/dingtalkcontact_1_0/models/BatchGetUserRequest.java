// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class BatchGetUserRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static BatchGetUserRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchGetUserRequest self = new BatchGetUserRequest();
        return TeaModel.build(map, self);
    }

    public BatchGetUserRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
