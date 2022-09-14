// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListTeamMembersRequest extends TeaModel {
    // 操作用户unionId。
    @NameInMap("operatorId")
    public String operatorId;

    public static ListTeamMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        ListTeamMembersRequest self = new ListTeamMembersRequest();
        return TeaModel.build(map, self);
    }

    public ListTeamMembersRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
