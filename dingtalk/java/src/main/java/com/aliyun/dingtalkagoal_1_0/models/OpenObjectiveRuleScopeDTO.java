// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenObjectiveRuleScopeDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>82347xxx2382</p>
     */
    @NameInMap("scopeId")
    public String scopeId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>USER</p>
     */
    @NameInMap("scopeType")
    public String scopeType;

    public static OpenObjectiveRuleScopeDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenObjectiveRuleScopeDTO self = new OpenObjectiveRuleScopeDTO();
        return TeaModel.build(map, self);
    }

    public OpenObjectiveRuleScopeDTO setScopeId(String scopeId) {
        this.scopeId = scopeId;
        return this;
    }
    public String getScopeId() {
        return this.scopeId;
    }

    public OpenObjectiveRuleScopeDTO setScopeType(String scopeType) {
        this.scopeType = scopeType;
        return this;
    }
    public String getScopeType() {
        return this.scopeType;
    }

}
