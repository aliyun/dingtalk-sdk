// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TransformToNormalAccountRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static TransformToNormalAccountRequest build(java.util.Map<String, ?> map) throws Exception {
        TransformToNormalAccountRequest self = new TransformToNormalAccountRequest();
        return TeaModel.build(map, self);
    }

    public TransformToNormalAccountRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
