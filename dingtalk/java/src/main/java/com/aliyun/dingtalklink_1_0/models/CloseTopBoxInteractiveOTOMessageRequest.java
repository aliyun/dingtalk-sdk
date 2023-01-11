// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class CloseTopBoxInteractiveOTOMessageRequest extends TeaModel {
    /**
     * <p>卡片参数</p>
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
         * <p>唯一标识一张卡片的ID，卡片幂等ID</p>
         */
        @NameInMap("cardBizId")
        public String cardBizId;

        /**
         * <p>卡片模板 ID</p>
         */
        @NameInMap("cardTemplateId")
        public String cardTemplateId;

        /**
         * <p>用户 userId</p>
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
