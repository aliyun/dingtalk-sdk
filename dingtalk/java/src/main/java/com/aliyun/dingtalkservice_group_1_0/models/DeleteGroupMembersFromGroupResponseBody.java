// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class DeleteGroupMembersFromGroupResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static DeleteGroupMembersFromGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteGroupMembersFromGroupResponseBody self = new DeleteGroupMembersFromGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteGroupMembersFromGroupResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
