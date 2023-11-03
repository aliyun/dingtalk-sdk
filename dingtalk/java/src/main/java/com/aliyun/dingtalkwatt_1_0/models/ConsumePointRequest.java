// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class ConsumePointRequest extends TeaModel {
    @NameInMap("body")
    public ConsumePointRequestBody body;

    public static ConsumePointRequest build(java.util.Map<String, ?> map) throws Exception {
        ConsumePointRequest self = new ConsumePointRequest();
        return TeaModel.build(map, self);
    }

    public ConsumePointRequest setBody(ConsumePointRequestBody body) {
        this.body = body;
        return this;
    }
    public ConsumePointRequestBody getBody() {
        return this.body;
    }

    public static class ConsumePointRequestBodyConsumeDetailBenefit extends TeaModel {
        @NameInMap("benefitId")
        public String benefitId;

        @NameInMap("name")
        public String name;

        @NameInMap("supplierName")
        public String supplierName;

        @NameInMap("useUrl")
        public String useUrl;

        public static ConsumePointRequestBodyConsumeDetailBenefit build(java.util.Map<String, ?> map) throws Exception {
            ConsumePointRequestBodyConsumeDetailBenefit self = new ConsumePointRequestBodyConsumeDetailBenefit();
            return TeaModel.build(map, self);
        }

        public ConsumePointRequestBodyConsumeDetailBenefit setBenefitId(String benefitId) {
            this.benefitId = benefitId;
            return this;
        }
        public String getBenefitId() {
            return this.benefitId;
        }

        public ConsumePointRequestBodyConsumeDetailBenefit setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ConsumePointRequestBodyConsumeDetailBenefit setSupplierName(String supplierName) {
            this.supplierName = supplierName;
            return this;
        }
        public String getSupplierName() {
            return this.supplierName;
        }

        public ConsumePointRequestBodyConsumeDetailBenefit setUseUrl(String useUrl) {
            this.useUrl = useUrl;
            return this;
        }
        public String getUseUrl() {
            return this.useUrl;
        }

    }

    public static class ConsumePointRequestBodyConsumeDetail extends TeaModel {
        @NameInMap("benefit")
        public ConsumePointRequestBodyConsumeDetailBenefit benefit;

        @NameInMap("type")
        public String type;

        public static ConsumePointRequestBodyConsumeDetail build(java.util.Map<String, ?> map) throws Exception {
            ConsumePointRequestBodyConsumeDetail self = new ConsumePointRequestBodyConsumeDetail();
            return TeaModel.build(map, self);
        }

        public ConsumePointRequestBodyConsumeDetail setBenefit(ConsumePointRequestBodyConsumeDetailBenefit benefit) {
            this.benefit = benefit;
            return this;
        }
        public ConsumePointRequestBodyConsumeDetailBenefit getBenefit() {
            return this.benefit;
        }

        public ConsumePointRequestBodyConsumeDetail setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class ConsumePointRequestBody extends TeaModel {
        @NameInMap("consumeDetail")
        public ConsumePointRequestBodyConsumeDetail consumeDetail;

        @NameInMap("pointPoolCode")
        public String pointPoolCode;

        @NameInMap("points")
        public Long points;

        @NameInMap("requestId")
        public String requestId;

        public static ConsumePointRequestBody build(java.util.Map<String, ?> map) throws Exception {
            ConsumePointRequestBody self = new ConsumePointRequestBody();
            return TeaModel.build(map, self);
        }

        public ConsumePointRequestBody setConsumeDetail(ConsumePointRequestBodyConsumeDetail consumeDetail) {
            this.consumeDetail = consumeDetail;
            return this;
        }
        public ConsumePointRequestBodyConsumeDetail getConsumeDetail() {
            return this.consumeDetail;
        }

        public ConsumePointRequestBody setPointPoolCode(String pointPoolCode) {
            this.pointPoolCode = pointPoolCode;
            return this;
        }
        public String getPointPoolCode() {
            return this.pointPoolCode;
        }

        public ConsumePointRequestBody setPoints(Long points) {
            this.points = points;
            return this;
        }
        public Long getPoints() {
            return this.points;
        }

        public ConsumePointRequestBody setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
