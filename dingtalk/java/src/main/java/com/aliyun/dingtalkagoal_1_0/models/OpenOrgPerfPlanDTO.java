// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenOrgPerfPlanDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("planId")
    public String planId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("title")
    public String title;

    public static OpenOrgPerfPlanDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenOrgPerfPlanDTO self = new OpenOrgPerfPlanDTO();
        return TeaModel.build(map, self);
    }

    public OpenOrgPerfPlanDTO setPlanId(String planId) {
        this.planId = planId;
        return this;
    }
    public String getPlanId() {
        return this.planId;
    }

    public OpenOrgPerfPlanDTO setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public OpenOrgPerfPlanDTO setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
