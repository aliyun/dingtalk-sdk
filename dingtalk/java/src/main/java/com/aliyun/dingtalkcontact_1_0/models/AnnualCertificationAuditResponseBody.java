// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AnnualCertificationAuditResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static AnnualCertificationAuditResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AnnualCertificationAuditResponseBody self = new AnnualCertificationAuditResponseBody();
        return TeaModel.build(map, self);
    }

    public AnnualCertificationAuditResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
