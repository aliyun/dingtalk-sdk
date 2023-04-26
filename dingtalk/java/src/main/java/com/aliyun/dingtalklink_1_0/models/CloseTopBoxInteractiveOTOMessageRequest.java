// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class CloseTopBoxInteractiveOTOMessageRequest extends TeaModel {
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
        @NameInMap("cardBizId")
        public String cardBizId;

        @NameInMap("cardTemplateId")
        public String cardTemplateId;

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
