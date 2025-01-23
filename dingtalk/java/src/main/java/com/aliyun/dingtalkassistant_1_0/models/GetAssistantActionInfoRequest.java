// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class GetAssistantActionInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("assistantId")
    public String assistantId;

    public static GetAssistantActionInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAssistantActionInfoRequest self = new GetAssistantActionInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetAssistantActionInfoRequest setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

}
