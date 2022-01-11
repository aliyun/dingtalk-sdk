// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class ReadMessageRequest extends TeaModel {
    @NameInMap("messageId")
    public String messageId;

    @NameInMap("operatorUid")
    public String operatorUid;

    public static ReadMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        ReadMessageRequest self = new ReadMessageRequest();
        return TeaModel.build(map, self);
    }

    public ReadMessageRequest setMessageId(String messageId) {
        this.messageId = messageId;
        return this;
    }
    public String getMessageId() {
        return this.messageId;
    }

    public ReadMessageRequest setOperatorUid(String operatorUid) {
        this.operatorUid = operatorUid;
        return this;
    }
    public String getOperatorUid() {
        return this.operatorUid;
    }

}
