// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelTaskMetaRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("optWorkNo")
    public String optWorkNo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sessionId")
    public String sessionId;

    public static HrbrainLabelTaskMetaRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelTaskMetaRequest self = new HrbrainLabelTaskMetaRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelTaskMetaRequest setOptWorkNo(String optWorkNo) {
        this.optWorkNo = optWorkNo;
        return this;
    }
    public String getOptWorkNo() {
        return this.optWorkNo;
    }

    public HrbrainLabelTaskMetaRequest setSessionId(String sessionId) {
        this.sessionId = sessionId;
        return this;
    }
    public String getSessionId() {
        return this.sessionId;
    }

}
