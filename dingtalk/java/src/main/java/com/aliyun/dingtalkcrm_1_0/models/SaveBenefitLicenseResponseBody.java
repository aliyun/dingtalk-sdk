// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class SaveBenefitLicenseResponseBody extends TeaModel {
    @NameInMap("result")
    public SaveBenefitLicenseResponseBodyResult result;

    public static SaveBenefitLicenseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveBenefitLicenseResponseBody self = new SaveBenefitLicenseResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveBenefitLicenseResponseBody setResult(SaveBenefitLicenseResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SaveBenefitLicenseResponseBodyResult getResult() {
        return this.result;
    }

    public static class SaveBenefitLicenseResponseBodyResultLicenses extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>license账号信息</p>
         */
        @NameInMap("licenseUserId")
        public String licenseUserId;

        public static SaveBenefitLicenseResponseBodyResultLicenses build(java.util.Map<String, ?> map) throws Exception {
            SaveBenefitLicenseResponseBodyResultLicenses self = new SaveBenefitLicenseResponseBodyResultLicenses();
            return TeaModel.build(map, self);
        }

        public SaveBenefitLicenseResponseBodyResultLicenses setLicenseUserId(String licenseUserId) {
            this.licenseUserId = licenseUserId;
            return this;
        }
        public String getLicenseUserId() {
            return this.licenseUserId;
        }

    }

    public static class SaveBenefitLicenseResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>B_ACCOUNT_NUMBER</p>
         */
        @NameInMap("domain")
        public String domain;

        @NameInMap("licenses")
        public java.util.List<SaveBenefitLicenseResponseBodyResultLicenses> licenses;

        public static SaveBenefitLicenseResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SaveBenefitLicenseResponseBodyResult self = new SaveBenefitLicenseResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SaveBenefitLicenseResponseBodyResult setDomain(String domain) {
            this.domain = domain;
            return this;
        }
        public String getDomain() {
            return this.domain;
        }

        public SaveBenefitLicenseResponseBodyResult setLicenses(java.util.List<SaveBenefitLicenseResponseBodyResultLicenses> licenses) {
            this.licenses = licenses;
            return this;
        }
        public java.util.List<SaveBenefitLicenseResponseBodyResultLicenses> getLicenses() {
            return this.licenses;
        }

    }

}
