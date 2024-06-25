// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ValidateUserRoleRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1677600000000</p>
     */
    @NameInMap("timeThreshold")
    public Long timeThreshold;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>VYn5fYjORJMi</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static ValidateUserRoleRequest build(java.util.Map<String, ?> map) throws Exception {
        ValidateUserRoleRequest self = new ValidateUserRoleRequest();
        return TeaModel.build(map, self);
    }

    public ValidateUserRoleRequest setTimeThreshold(Long timeThreshold) {
        this.timeThreshold = timeThreshold;
        return this;
    }
    public Long getTimeThreshold() {
        return this.timeThreshold;
    }

    public ValidateUserRoleRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
