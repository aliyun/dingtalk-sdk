// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListRelatedSpaceTeamsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("type")
    public Integer type;

    public static ListRelatedSpaceTeamsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListRelatedSpaceTeamsRequest self = new ListRelatedSpaceTeamsRequest();
        return TeaModel.build(map, self);
    }

    public ListRelatedSpaceTeamsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public ListRelatedSpaceTeamsRequest setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
    }

}
