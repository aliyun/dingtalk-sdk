// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class ConfirmContractReviewResponseBody extends TeaModel {
    @NameInMap("data")
    public ConfirmContractReviewResponseBodyData data;

    public static ConfirmContractReviewResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ConfirmContractReviewResponseBody self = new ConfirmContractReviewResponseBody();
        return TeaModel.build(map, self);
    }

    public ConfirmContractReviewResponseBody setData(ConfirmContractReviewResponseBodyData data) {
        this.data = data;
        return this;
    }
    public ConfirmContractReviewResponseBodyData getData() {
        return this.data;
    }

    public static class ConfirmContractReviewResponseBodyDataRecommended extends TeaModel {
        @NameInMap("contract_type")
        public String contractType;

        @NameInMap("scale")
        public String scale;

        @NameInMap("standpoint")
        public String standpoint;

        public static ConfirmContractReviewResponseBodyDataRecommended build(java.util.Map<String, ?> map) throws Exception {
            ConfirmContractReviewResponseBodyDataRecommended self = new ConfirmContractReviewResponseBodyDataRecommended();
            return TeaModel.build(map, self);
        }

        public ConfirmContractReviewResponseBodyDataRecommended setContractType(String contractType) {
            this.contractType = contractType;
            return this;
        }
        public String getContractType() {
            return this.contractType;
        }

        public ConfirmContractReviewResponseBodyDataRecommended setScale(String scale) {
            this.scale = scale;
            return this;
        }
        public String getScale() {
            return this.scale;
        }

        public ConfirmContractReviewResponseBodyDataRecommended setStandpoint(String standpoint) {
            this.standpoint = standpoint;
            return this;
        }
        public String getStandpoint() {
            return this.standpoint;
        }

    }

    public static class ConfirmContractReviewResponseBodyData extends TeaModel {
        @NameInMap("recommended")
        public ConfirmContractReviewResponseBodyDataRecommended recommended;

        @NameInMap("review_id")
        public String reviewId;

        @NameInMap("status")
        public String status;

        public static ConfirmContractReviewResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            ConfirmContractReviewResponseBodyData self = new ConfirmContractReviewResponseBodyData();
            return TeaModel.build(map, self);
        }

        public ConfirmContractReviewResponseBodyData setRecommended(ConfirmContractReviewResponseBodyDataRecommended recommended) {
            this.recommended = recommended;
            return this;
        }
        public ConfirmContractReviewResponseBodyDataRecommended getRecommended() {
            return this.recommended;
        }

        public ConfirmContractReviewResponseBodyData setReviewId(String reviewId) {
            this.reviewId = reviewId;
            return this;
        }
        public String getReviewId() {
            return this.reviewId;
        }

        public ConfirmContractReviewResponseBodyData setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
