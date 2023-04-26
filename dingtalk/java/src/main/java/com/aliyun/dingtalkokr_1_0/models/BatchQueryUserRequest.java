// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryUserRequest extends TeaModel {
    @NameInMap("okrUserIds")
    public java.util.List<String> okrUserIds;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static BatchQueryUserRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryUserRequest self = new BatchQueryUserRequest();
        return TeaModel.build(map, self);
    }

    public BatchQueryUserRequest setOkrUserIds(java.util.List<String> okrUserIds) {
        this.okrUserIds = okrUserIds;
        return this;
    }
    public java.util.List<String> getOkrUserIds() {
        return this.okrUserIds;
    }

    public BatchQueryUserRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
