// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CheckControlHitStatusRequest extends TeaModel {
    @NameInMap("needMissedFunction")
    public Boolean needMissedFunction;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>staffId</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CheckControlHitStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        CheckControlHitStatusRequest self = new CheckControlHitStatusRequest();
        return TeaModel.build(map, self);
    }

    public CheckControlHitStatusRequest setNeedMissedFunction(Boolean needMissedFunction) {
        this.needMissedFunction = needMissedFunction;
        return this;
    }
    public Boolean getNeedMissedFunction() {
        return this.needMissedFunction;
    }

    public CheckControlHitStatusRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
