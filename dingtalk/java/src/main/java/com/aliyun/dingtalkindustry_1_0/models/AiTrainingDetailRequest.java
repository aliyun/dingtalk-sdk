// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class AiTrainingDetailRequest extends TeaModel {
    @NameInMap("recordId")
    public Long recordId;

    public static AiTrainingDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        AiTrainingDetailRequest self = new AiTrainingDetailRequest();
        return TeaModel.build(map, self);
    }

    public AiTrainingDetailRequest setRecordId(Long recordId) {
        this.recordId = recordId;
        return this;
    }
    public Long getRecordId() {
        return this.recordId;
    }

}
