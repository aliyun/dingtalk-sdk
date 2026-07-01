// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ManageTeamMemberResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static ManageTeamMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ManageTeamMemberResponseBody self = new ManageTeamMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public ManageTeamMemberResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
