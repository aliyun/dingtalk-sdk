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
         * 
         * <strong>example:</strong>
         * <p>B_ACCOUNT_NUMBER</p>
         */
        @NameInMap("benefitCode")
        public String benefitCode;

        /**
         * <strong>example:</strong>
         * <p>1718696461851</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <strong>example:</strong>
         * <p>200</p>
         */
        @NameInMap("quota")
        public Long quota;

        /**
         * <strong>example:</strong>
         * <p>1718696461851</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
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

        public ListAvailableBenefitResponseBodyResult setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public ListAvailableBenefitResponseBodyResult setQuota(Long quota) {
            this.quota = quota;
            return this;
        }
        public Long getQuota() {
            return this.quota;
        }

        public ListAvailableBenefitResponseBodyResult setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
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
