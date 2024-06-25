// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class RemoveResidentMemberRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    /**
     * <strong>example:</strong>
     * <p>111112***</p>
     */
    @NameInMap("userId")
    public String userId;

    public static RemoveResidentMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveResidentMemberRequest self = new RemoveResidentMemberRequest();
        return TeaModel.build(map, self);
    }

    public RemoveResidentMemberRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public RemoveResidentMemberRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public RemoveResidentMemberRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
