// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class BatchDeleteRoleMembersResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static BatchDeleteRoleMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchDeleteRoleMembersResponseBody self = new BatchDeleteRoleMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchDeleteRoleMembersResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
