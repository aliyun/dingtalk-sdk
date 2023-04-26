// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetFlowIdByRelationEntityIdRequest extends TeaModel {
    @NameInMap("bizCode")
    public String bizCode;

    @NameInMap("relationEntity")
    public String relationEntity;

    @NameInMap("relationEntityId")
    public String relationEntityId;

    public static GetFlowIdByRelationEntityIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFlowIdByRelationEntityIdRequest self = new GetFlowIdByRelationEntityIdRequest();
        return TeaModel.build(map, self);
    }

    public GetFlowIdByRelationEntityIdRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public GetFlowIdByRelationEntityIdRequest setRelationEntity(String relationEntity) {
        this.relationEntity = relationEntity;
        return this;
    }
    public String getRelationEntity() {
        return this.relationEntity;
    }

    public GetFlowIdByRelationEntityIdRequest setRelationEntityId(String relationEntityId) {
        this.relationEntityId = relationEntityId;
        return this;
    }
    public String getRelationEntityId() {
        return this.relationEntityId;
    }

}
