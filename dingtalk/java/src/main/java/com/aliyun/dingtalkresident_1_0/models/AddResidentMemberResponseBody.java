// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddResidentMemberResponseBody extends TeaModel {
    @NameInMap("status")
    public Integer status;

    /**
     * <strong>example:</strong>
     * <p>10005</p>
     */
    @NameInMap("unionId")
    public String unionId;

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
