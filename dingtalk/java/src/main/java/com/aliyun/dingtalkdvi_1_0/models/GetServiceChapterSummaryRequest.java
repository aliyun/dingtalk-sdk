// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetServiceChapterSummaryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("recordId")
    public String recordId;

    public static GetServiceChapterSummaryRequest build(java.util.Map<String, ?> map) throws Exception {
        GetServiceChapterSummaryRequest self = new GetServiceChapterSummaryRequest();
        return TeaModel.build(map, self);
    }

    public GetServiceChapterSummaryRequest setRecordId(String recordId) {
        this.recordId = recordId;
        return this;
    }
    public String getRecordId() {
        return this.recordId;
    }

}
