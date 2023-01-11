// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddResidentMemberResponseBody extends TeaModel {
    /**
     * <p>用户状态</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>用户ID</p>
     */
    @NameInMap("unionId")
    public String unionId;

    /**
     * <p>用户员工ID</p>
     */
    @NameInMap("userId")
    public String userId;

    public static AddResidentMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddResidentMemberResponseBody self = new AddResidentMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public AddResidentMemberResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public AddResidentMemberResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public AddResidentMemberResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
