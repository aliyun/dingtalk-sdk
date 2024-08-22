// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryMessageSendResultRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>dhowhi23ohdh==</p>
     */
    @NameInMap("openTaskId")
    public String openTaskId;

    public static QueryMessageSendResultRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMessageSendResultRequest self = new QueryMessageSendResultRequest();
        return TeaModel.build(map, self);
    }

    public QueryMessageSendResultRequest setOpenTaskId(String openTaskId) {
        this.openTaskId = openTaskId;
        return this;
    }
    public String getOpenTaskId() {
        return this.openTaskId;
    }

}
