// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class UpdateTeamRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>这是更新后的简介</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <strong>example:</strong>
     * <p>更新后的名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>YEp3JcM******UIbhwiE</p>
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
