// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AddAppToWorkBenchGroupRequest extends TeaModel {
    // 创建人unionId
    @NameInMap("opUnionId")
    public String opUnionId;

    // 关联组织corpId
    @NameInMap("ecologicalCorpId")
    public String ecologicalCorpId;

    // 工作台分组id
    @NameInMap("componentId")
    public String componentId;

    public static AddAppToWorkBenchGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        AddAppToWorkBenchGroupRequest self = new AddAppToWorkBenchGroupRequest();
        return TeaModel.build(map, self);
    }

    public AddAppToWorkBenchGroupRequest setOpUnionId(String opUnionId) {
        this.opUnionId = opUnionId;
        return this;
    }
    public String getOpUnionId() {
        return this.opUnionId;
    }

    public AddAppToWorkBenchGroupRequest setEcologicalCorpId(String ecologicalCorpId) {
        this.ecologicalCorpId = ecologicalCorpId;
        return this;
    }
    public String getEcologicalCorpId() {
        return this.ecologicalCorpId;
    }

    public AddAppToWorkBenchGroupRequest setComponentId(String componentId) {
        this.componentId = componentId;
        return this;
    }
    public String getComponentId() {
        return this.componentId;
    }

}
