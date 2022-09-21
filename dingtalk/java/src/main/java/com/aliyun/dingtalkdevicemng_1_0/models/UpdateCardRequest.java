// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class UpdateCardRequest extends TeaModel {
    // 卡片实例唯一标识
    @NameInMap("bizId")
    public String bizId;

    // 卡片变量赋值，json结构
    @NameInMap("cardData")
    public String cardData;

    // 卡片更新群系统通知
    @NameInMap("tips")
    public UpdateCardRequestTips tips;

    public static UpdateCardRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCardRequest self = new UpdateCardRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCardRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public UpdateCardRequest setCardData(String cardData) {
        this.cardData = cardData;
        return this;
    }
    public String getCardData() {
        return this.cardData;
    }

    public UpdateCardRequest setTips(UpdateCardRequestTips tips) {
        this.tips = tips;
        return this;
    }
    public UpdateCardRequestTips getTips() {
        return this.tips;
    }

    public static class UpdateCardRequestTips extends TeaModel {
        // 系统通知的群组
        @NameInMap("cids")
        public String cids;

        // 系统通知内容
        @NameInMap("content")
        public String content;

        // 发送人
        @NameInMap("sender")
        public String sender;

        public static UpdateCardRequestTips build(java.util.Map<String, ?> map) throws Exception {
            UpdateCardRequestTips self = new UpdateCardRequestTips();
            return TeaModel.build(map, self);
        }

        public UpdateCardRequestTips setCids(String cids) {
            this.cids = cids;
            return this;
        }
        public String getCids() {
            return this.cids;
        }

        public UpdateCardRequestTips setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public UpdateCardRequestTips setSender(String sender) {
            this.sender = sender;
            return this;
        }
        public String getSender() {
            return this.sender;
        }

    }

}
