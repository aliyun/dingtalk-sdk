// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ListBenefitLicenseResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public java.util.List<ListBenefitLicenseResponseBodyResult> result;

    public static ListBenefitLicenseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListBenefitLicenseResponseBody self = new ListBenefitLicenseResponseBody();
        return TeaModel.build(map, self);
    }

    public ListBenefitLicenseResponseBody setResult(java.util.List<ListBenefitLicenseResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListBenefitLicenseResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ListBenefitLicenseResponseBodyResultLicenses extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("licenseUserId")
        public String licenseUserId;

        public static ListBenefitLicenseResponseBodyResultLicenses build(java.util.Map<String, ?> map) throws Exception {
            ListBenefitLicenseResponseBodyResultLicenses self = new ListBenefitLicenseResponseBodyResultLicenses();
            return TeaModel.build(map, self);
        }

        public ListBenefitLicenseResponseBodyResultLicenses setLicenseUserId(String licenseUserId) {
            this.licenseUserId = licenseUserId;
            return this;
        }
        public String getLicenseUserId() {
            return this.licenseUserId;
        }

    }

    public static class ListBenefitLicenseResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("domain")
        public String domain;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("licenses")
        public java.util.List<ListBenefitLicenseResponseBodyResultLicenses> licenses;

        public static ListBenefitLicenseResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListBenefitLicenseResponseBodyResult self = new ListBenefitLicenseResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListBenefitLicenseResponseBodyResult setDomain(String domain) {
            this.domain = domain;
            return this;
        }
        public String getDomain() {
            return this.domain;
        }

        public ListBenefitLicenseResponseBodyResult setLicenses(java.util.List<ListBenefitLicenseResponseBodyResultLicenses> licenses) {
            this.licenses = licenses;
            return this;
        }
        public java.util.List<ListBenefitLicenseResponseBodyResultLicenses> getLicenses() {
            return this.licenses;
        }

    }

}
