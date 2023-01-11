// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddContactMemberToGroupResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static AddContactMemberToGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddContactMemberToGroupResponseBody self = new AddContactMemberToGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public AddContactMemberToGroupResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
