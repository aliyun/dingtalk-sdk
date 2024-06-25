// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendTemplateInteractiveCardResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xxxxxx</p>
     */
    @NameInMap("processQueryKey")
    public String processQueryKey;

    public static SendTemplateInteractiveCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendTemplateInteractiveCardResponseBody self = new SendTemplateInteractiveCardResponseBody();
        return TeaModel.build(map, self);
    }

    public SendTemplateInteractiveCardResponseBody setProcessQueryKey(String processQueryKey) {
        this.processQueryKey = processQueryKey;
        return this;
    }
    public String getProcessQueryKey() {
        return this.processQueryKey;
    }

}
