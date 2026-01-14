// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetServiceQualityInspectionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("recordId")
    public String recordId;

    public static GetServiceQualityInspectionRequest build(java.util.Map<String, ?> map) throws Exception {
        GetServiceQualityInspectionRequest self = new GetServiceQualityInspectionRequest();
        return TeaModel.build(map, self);
    }

    public GetServiceQualityInspectionRequest setRecordId(String recordId) {
        this.recordId = recordId;
        return this;
    }
    public String getRecordId() {
        return this.recordId;
    }

}
