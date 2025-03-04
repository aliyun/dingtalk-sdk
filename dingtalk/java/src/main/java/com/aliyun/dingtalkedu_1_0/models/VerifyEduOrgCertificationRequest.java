// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class VerifyEduOrgCertificationRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>TEST</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <strong>example:</strong>
     * <p>ding1234</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static VerifyEduOrgCertificationRequest build(java.util.Map<String, ?> map) throws Exception {
        VerifyEduOrgCertificationRequest self = new VerifyEduOrgCertificationRequest();
        return TeaModel.build(map, self);
    }

    public VerifyEduOrgCertificationRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public VerifyEduOrgCertificationRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
