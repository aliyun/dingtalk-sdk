// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class VerifyEduOrgCertificationResponseBody extends TeaModel {
    @NameInMap("certificated")
    public Boolean certificated;

    public static VerifyEduOrgCertificationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        VerifyEduOrgCertificationResponseBody self = new VerifyEduOrgCertificationResponseBody();
        return TeaModel.build(map, self);
    }

    public VerifyEduOrgCertificationResponseBody setCertificated(Boolean certificated) {
        this.certificated = certificated;
        return this;
    }
    public Boolean getCertificated() {
        return this.certificated;
    }

}
