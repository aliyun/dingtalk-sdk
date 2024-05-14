// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AddAppToWorkBenchGroupRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("componentId")
    public String componentId;

    @NameInMap("ecologicalCorpId")
    public String ecologicalCorpId;

    @NameInMap("opUnionId")
    public String opUnionId;

    public static AddAppToWorkBenchGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        AddAppToWorkBenchGroupRequest self = new AddAppToWorkBenchGroupRequest();
        return TeaModel.build(map, self);
    }

    public AddAppToWorkBenchGroupRequest setComponentId(String componentId) {
        this.componentId = componentId;
        return this;
    }
    public String getComponentId() {
        return this.componentId;
    }

    public AddAppToWorkBenchGroupRequest setEcologicalCorpId(String ecologicalCorpId) {
        this.ecologicalCorpId = ecologicalCorpId;
        return this;
    }
    public String getEcologicalCorpId() {
        return this.ecologicalCorpId;
    }

    public AddAppToWorkBenchGroupRequest setOpUnionId(String opUnionId) {
        this.opUnionId = opUnionId;
        return this;
    }
    public String getOpUnionId() {
        return this.opUnionId;
    }

}
