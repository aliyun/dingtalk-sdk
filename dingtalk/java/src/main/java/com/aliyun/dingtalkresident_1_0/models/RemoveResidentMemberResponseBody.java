// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class RemoveResidentMemberResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static RemoveResidentMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveResidentMemberResponseBody self = new RemoveResidentMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveResidentMemberResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
