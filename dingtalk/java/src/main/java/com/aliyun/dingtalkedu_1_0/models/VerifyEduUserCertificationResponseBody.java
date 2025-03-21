// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class VerifyEduUserCertificationResponseBody extends TeaModel {
    @NameInMap("certificated")
    public Boolean certificated;

    @NameInMap("certificatedCorpId")
    public String certificatedCorpId;

    @NameInMap("certificatedOrgName")
    public String certificatedOrgName;

    @NameInMap("certificatedUserId")
    public String certificatedUserId;

    public static VerifyEduUserCertificationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        VerifyEduUserCertificationResponseBody self = new VerifyEduUserCertificationResponseBody();
        return TeaModel.build(map, self);
    }

    public VerifyEduUserCertificationResponseBody setCertificated(Boolean certificated) {
        this.certificated = certificated;
        return this;
    }
    public Boolean getCertificated() {
        return this.certificated;
    }

    public VerifyEduUserCertificationResponseBody setCertificatedCorpId(String certificatedCorpId) {
        this.certificatedCorpId = certificatedCorpId;
        return this;
    }
    public String getCertificatedCorpId() {
        return this.certificatedCorpId;
    }

    public VerifyEduUserCertificationResponseBody setCertificatedOrgName(String certificatedOrgName) {
        this.certificatedOrgName = certificatedOrgName;
        return this;
    }
    public String getCertificatedOrgName() {
        return this.certificatedOrgName;
    }

    public VerifyEduUserCertificationResponseBody setCertificatedUserId(String certificatedUserId) {
        this.certificatedUserId = certificatedUserId;
        return this;
    }
    public String getCertificatedUserId() {
        return this.certificatedUserId;
    }

}
