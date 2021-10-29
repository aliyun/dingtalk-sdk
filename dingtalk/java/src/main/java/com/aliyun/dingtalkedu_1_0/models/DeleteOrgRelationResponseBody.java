// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteOrgRelationResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteOrgRelationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteOrgRelationResponseBody self = new DeleteOrgRelationResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteOrgRelationResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
