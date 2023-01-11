// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class DeleteTeamRequest extends TeaModel {
    /**
     * <p>操作人unionId。</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DeleteTeamRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteTeamRequest self = new DeleteTeamRequest();
        return TeaModel.build(map, self);
    }

    public DeleteTeamRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
