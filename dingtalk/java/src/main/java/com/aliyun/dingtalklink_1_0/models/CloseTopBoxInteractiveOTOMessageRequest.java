// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class CloseTopBoxInteractiveOTOMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("detail")
    public CloseTopBoxInteractiveOTOMessageRequestDetail detail;

    public static CloseTopBoxInteractiveOTOMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        CloseTopBoxInteractiveOTOMessageRequest self = new CloseTopBoxInteractiveOTOMessageRequest();
        return TeaModel.build(map, self);
    }

    public CloseTopBoxInteractiveOTOMessageRequest setDetail(CloseTopBoxInteractiveOTOMessageRequestDetail detail) {
        this.detail = detail;
        return this;
    }
    public CloseTopBoxInteractiveOTOMessageRequestDetail getDetail() {
        return this.detail;
    }

    public static class CloseTopBoxInteractiveOTOMessageRequestDetail extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>service-card-20220824-001</p>
         */
        @NameInMap("cardBizId")
        public String cardBizId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>3erkfi-42b0-4c83-bc56-ffhssde43</p>
         */
        @NameInMap("cardTemplateId")
        public String cardTemplateId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>user001</p>
         */
        @NameInMap("userId")
        public String userId;

        public static CloseTopBoxInteractiveOTOMessageRequestDetail build(java.util.Map<String, ?> map) throws Exception {
            CloseTopBoxInteractiveOTOMessageRequestDetail self = new CloseTopBoxInteractiveOTOMessageRequestDetail();
            return TeaModel.build(map, self);
        }

        public CloseTopBoxInteractiveOTOMessageRequestDetail setCardBizId(String cardBizId) {
            this.cardBizId = cardBizId;
            return this;
        }
        public String getCardBizId() {
            return this.cardBizId;
        }

        public CloseTopBoxInteractiveOTOMessageRequestDetail setCardTemplateId(String cardTemplateId) {
            this.cardTemplateId = cardTemplateId;
            return this;
        }
        public String getCardTemplateId() {
            return this.cardTemplateId;
        }

        public CloseTopBoxInteractiveOTOMessageRequestDetail setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
