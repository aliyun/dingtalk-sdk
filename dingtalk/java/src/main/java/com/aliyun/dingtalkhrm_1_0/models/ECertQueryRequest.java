// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class ECertQueryRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>manager231</p>
     * 
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ECertQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        ECertQueryRequest self = new ECertQueryRequest();
        return TeaModel.build(map, self);
    }

    public ECertQueryRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
