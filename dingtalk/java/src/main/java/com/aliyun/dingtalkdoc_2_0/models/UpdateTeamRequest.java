// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class UpdateTeamRequest extends TeaModel {
    /**
     * <p>小组介绍。和小组名称至少有一个必填。</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>小组名称。和小组介绍至少有一个必填。</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>操作人unionId。</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static UpdateTeamRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTeamRequest self = new UpdateTeamRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTeamRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateTeamRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateTeamRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
