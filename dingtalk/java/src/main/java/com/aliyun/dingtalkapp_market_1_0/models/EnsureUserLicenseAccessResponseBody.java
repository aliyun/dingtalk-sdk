// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class EnsureUserLicenseAccessResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("allowed")
    public Boolean allowed;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>LICENSE_ASSIGNED_NOW</p>
     */
    @NameInMap("decisionCode")
    public String decisionCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("licenseAssigned")
    public Boolean licenseAssigned;

    public static EnsureUserLicenseAccessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EnsureUserLicenseAccessResponseBody self = new EnsureUserLicenseAccessResponseBody();
        return TeaModel.build(map, self);
    }

    public EnsureUserLicenseAccessResponseBody setAllowed(Boolean allowed) {
        this.allowed = allowed;
        return this;
    }
    public Boolean getAllowed() {
        return this.allowed;
    }

    public EnsureUserLicenseAccessResponseBody setDecisionCode(String decisionCode) {
        this.decisionCode = decisionCode;
        return this;
    }
    public String getDecisionCode() {
        return this.decisionCode;
    }

    public EnsureUserLicenseAccessResponseBody setLicenseAssigned(Boolean licenseAssigned) {
        this.licenseAssigned = licenseAssigned;
        return this;
    }
    public Boolean getLicenseAssigned() {
        return this.licenseAssigned;
    }

}
