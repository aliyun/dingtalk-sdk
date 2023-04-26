// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class RecallOfficialAccountOTOMessageResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static RecallOfficialAccountOTOMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RecallOfficialAccountOTOMessageResponseBody self = new RecallOfficialAccountOTOMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public RecallOfficialAccountOTOMessageResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
