// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleFlashMinutesAnalysisRequest extends TeaModel {
    @NameInMap("entityId")
    public String entityId;

    @NameInMap("userId")
    public String userId;

    public static AISaleFlashMinutesAnalysisRequest build(java.util.Map<String, ?> map) throws Exception {
        AISaleFlashMinutesAnalysisRequest self = new AISaleFlashMinutesAnalysisRequest();
        return TeaModel.build(map, self);
    }

    public AISaleFlashMinutesAnalysisRequest setEntityId(String entityId) {
        this.entityId = entityId;
        return this;
    }
    public String getEntityId() {
        return this.entityId;
    }

    public AISaleFlashMinutesAnalysisRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
