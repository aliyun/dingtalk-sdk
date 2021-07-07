// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class RecallMessageRequest extends TeaModel {
    @NameInMap("operatorUid")
    public String operatorUid;

    @NameInMap("messageId")
    public String messageId;

    public static RecallMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        RecallMessageRequest self = new RecallMessageRequest();
        return TeaModel.build(map, self);
    }

    public RecallMessageRequest setOperatorUid(String operatorUid) {
        this.operatorUid = operatorUid;
        return this;
    }
    public String getOperatorUid() {
        return this.operatorUid;
    }

    public RecallMessageRequest setMessageId(String messageId) {
        this.messageId = messageId;
        return this;
    }
    public String getMessageId() {
        return this.messageId;
    }

}
