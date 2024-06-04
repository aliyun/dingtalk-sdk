// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ListBenefitLicenseRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("domains")
    public java.util.List<String> domains;

    public static ListBenefitLicenseRequest build(java.util.Map<String, ?> map) throws Exception {
        ListBenefitLicenseRequest self = new ListBenefitLicenseRequest();
        return TeaModel.build(map, self);
    }

    public ListBenefitLicenseRequest setDomains(java.util.List<String> domains) {
        this.domains = domains;
        return this;
    }
    public java.util.List<String> getDomains() {
        return this.domains;
    }

}
