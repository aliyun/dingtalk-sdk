// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class SaveBenefitLicenseRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>B_ACCOUNT_NUMBER</p>
     */
    @NameInMap("domain")
    public String domain;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("licenses")
    public java.util.List<SaveBenefitLicenseRequestLicenses> licenses;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>staffId</p>
     */
    @NameInMap("saveUserId")
    public String saveUserId;

    public static SaveBenefitLicenseRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveBenefitLicenseRequest self = new SaveBenefitLicenseRequest();
        return TeaModel.build(map, self);
    }

    public SaveBenefitLicenseRequest setDomain(String domain) {
        this.domain = domain;
        return this;
    }
    public String getDomain() {
        return this.domain;
    }

    public SaveBenefitLicenseRequest setLicenses(java.util.List<SaveBenefitLicenseRequestLicenses> licenses) {
        this.licenses = licenses;
        return this;
    }
    public java.util.List<SaveBenefitLicenseRequestLicenses> getLicenses() {
        return this.licenses;
    }

    public SaveBenefitLicenseRequest setSaveUserId(String saveUserId) {
        this.saveUserId = saveUserId;
        return this;
    }
    public String getSaveUserId() {
        return this.saveUserId;
    }

    public static class SaveBenefitLicenseRequestLicenses extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>licenseStaffId</p>
         */
        @NameInMap("licenseUserId")
        public String licenseUserId;

        public static SaveBenefitLicenseRequestLicenses build(java.util.Map<String, ?> map) throws Exception {
            SaveBenefitLicenseRequestLicenses self = new SaveBenefitLicenseRequestLicenses();
            return TeaModel.build(map, self);
        }

        public SaveBenefitLicenseRequestLicenses setLicenseUserId(String licenseUserId) {
            this.licenseUserId = licenseUserId;
            return this;
        }
        public String getLicenseUserId() {
            return this.licenseUserId;
        }

    }

}
