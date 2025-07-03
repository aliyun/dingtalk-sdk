// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class BatchAddOrUpdateRoleMembersResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static BatchAddOrUpdateRoleMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchAddOrUpdateRoleMembersResponseBody self = new BatchAddOrUpdateRoleMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchAddOrUpdateRoleMembersResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
