// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class RecallHonorRequest extends TeaModel {
    @NameInMap("userId")
    public String userId;

    public static RecallHonorRequest build(java.util.Map<String, ?> map) throws Exception {
        RecallHonorRequest self = new RecallHonorRequest();
        return TeaModel.build(map, self);
    }

    public RecallHonorRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
