// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ListAvailableBenefitResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public java.util.List<ListAvailableBenefitResponseBodyResult> result;

    public static ListAvailableBenefitResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAvailableBenefitResponseBody self = new ListAvailableBenefitResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAvailableBenefitResponseBody setResult(java.util.List<ListAvailableBenefitResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListAvailableBenefitResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ListAvailableBenefitResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("benefitCode")
        public String benefitCode;

        @NameInMap("quota")
        public Long quota;

        @NameInMap("usedQuota")
        public Long usedQuota;

        public static ListAvailableBenefitResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListAvailableBenefitResponseBodyResult self = new ListAvailableBenefitResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListAvailableBenefitResponseBodyResult setBenefitCode(String benefitCode) {
            this.benefitCode = benefitCode;
            return this;
        }
        public String getBenefitCode() {
            return this.benefitCode;
        }

        public ListAvailableBenefitResponseBodyResult setQuota(Long quota) {
            this.quota = quota;
            return this;
        }
        public Long getQuota() {
            return this.quota;
        }

        public ListAvailableBenefitResponseBodyResult setUsedQuota(Long usedQuota) {
            this.usedQuota = usedQuota;
            return this;
        }
        public Long getUsedQuota() {
            return this.usedQuota;
        }

    }

}
