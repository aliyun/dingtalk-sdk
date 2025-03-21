// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class ListInstanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("prototypeAssistantId")
    public String prototypeAssistantId;

    public static ListInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        ListInstanceRequest self = new ListInstanceRequest();
        return TeaModel.build(map, self);
    }

    public ListInstanceRequest setPrototypeAssistantId(String prototypeAssistantId) {
        this.prototypeAssistantId = prototypeAssistantId;
        return this;
    }
    public String getPrototypeAssistantId() {
        return this.prototypeAssistantId;
    }

}
