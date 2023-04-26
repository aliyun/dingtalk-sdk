// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class DeleteObjectiveRequest extends TeaModel {
    @NameInMap("userId")
    public String userId;

    public static DeleteObjectiveRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteObjectiveRequest self = new DeleteObjectiveRequest();
        return TeaModel.build(map, self);
    }

    public DeleteObjectiveRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
