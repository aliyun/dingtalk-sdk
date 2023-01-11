// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class RemoveResidentMemberRequest extends TeaModel {
    /**
     * <p>空位标识</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>unionId</p>
     */
    @NameInMap("unionId")
    public String unionId;

    /**
     * <p>人员标识</p>
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
