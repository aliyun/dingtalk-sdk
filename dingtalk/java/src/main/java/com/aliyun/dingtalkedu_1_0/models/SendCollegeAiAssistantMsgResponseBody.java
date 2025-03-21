// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SendCollegeAiAssistantMsgResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SendCollegeAiAssistantMsgResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendCollegeAiAssistantMsgResponseBody self = new SendCollegeAiAssistantMsgResponseBody();
        return TeaModel.build(map, self);
    }

    public SendCollegeAiAssistantMsgResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
