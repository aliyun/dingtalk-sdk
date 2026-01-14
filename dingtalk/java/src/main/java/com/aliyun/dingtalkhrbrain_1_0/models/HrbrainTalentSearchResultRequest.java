// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainTalentSearchResultRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sessionId")
    public String sessionId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("workNo")
    public String workNo;

    public static HrbrainTalentSearchResultRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainTalentSearchResultRequest self = new HrbrainTalentSearchResultRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainTalentSearchResultRequest setSessionId(String sessionId) {
        this.sessionId = sessionId;
        return this;
    }
    public String getSessionId() {
        return this.sessionId;
    }

    public HrbrainTalentSearchResultRequest setWorkNo(String workNo) {
        this.workNo = workNo;
        return this;
    }
    public String getWorkNo() {
        return this.workNo;
    }

}
