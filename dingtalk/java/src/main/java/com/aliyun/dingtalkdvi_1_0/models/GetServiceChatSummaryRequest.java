// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetServiceChatSummaryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("recordId")
    public String recordId;

    public static GetServiceChatSummaryRequest build(java.util.Map<String, ?> map) throws Exception {
        GetServiceChatSummaryRequest self = new GetServiceChatSummaryRequest();
        return TeaModel.build(map, self);
    }

    public GetServiceChatSummaryRequest setRecordId(String recordId) {
        this.recordId = recordId;
        return this;
    }
    public String getRecordId() {
        return this.recordId;
    }

}
