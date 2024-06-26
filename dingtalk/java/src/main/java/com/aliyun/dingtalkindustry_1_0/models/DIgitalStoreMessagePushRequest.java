// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DIgitalStoreMessagePushRequest extends TeaModel {
    @NameInMap("messageDataList")
    public java.util.List<DIgitalStoreMessagePushRequestMessageDataList> messageDataList;

    public static DIgitalStoreMessagePushRequest build(java.util.Map<String, ?> map) throws Exception {
        DIgitalStoreMessagePushRequest self = new DIgitalStoreMessagePushRequest();
        return TeaModel.build(map, self);
    }

    public DIgitalStoreMessagePushRequest setMessageDataList(java.util.List<DIgitalStoreMessagePushRequestMessageDataList> messageDataList) {
        this.messageDataList = messageDataList;
        return this;
    }
    public java.util.List<DIgitalStoreMessagePushRequestMessageDataList> getMessageDataList() {
        return this.messageDataList;
    }

    public static class DIgitalStoreMessagePushRequestMessageDataList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>xxxxcallback</p>
         */
        @NameInMap("callbackKey")
        public String callbackKey;

        /**
         * <strong>example:</strong>
         * <p>{&quot;key&quot;:&quot;value&quot;}</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("newCard")
        public Boolean newCard;

        /**
         * <strong>example:</strong>
         * <p>ysn138dh1712dsa</p>
         */
        @NameInMap("outTraceId")
        public String outTraceId;

        /**
         * <strong>example:</strong>
         * <p>StoreOrder</p>
         */
        @NameInMap("sceneCardCode")
        public String sceneCardCode;

        /**
         * <strong>example:</strong>
         * <p>54774321</p>
         */
        @NameInMap("sceneScope")
        public Long sceneScope;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("sendNow")
        public Boolean sendNow;

        public static DIgitalStoreMessagePushRequestMessageDataList build(java.util.Map<String, ?> map) throws Exception {
            DIgitalStoreMessagePushRequestMessageDataList self = new DIgitalStoreMessagePushRequestMessageDataList();
            return TeaModel.build(map, self);
        }

        public DIgitalStoreMessagePushRequestMessageDataList setCallbackKey(String callbackKey) {
            this.callbackKey = callbackKey;
            return this;
        }
        public String getCallbackKey() {
            return this.callbackKey;
        }

        public DIgitalStoreMessagePushRequestMessageDataList setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DIgitalStoreMessagePushRequestMessageDataList setNewCard(Boolean newCard) {
            this.newCard = newCard;
            return this;
        }
        public Boolean getNewCard() {
            return this.newCard;
        }

        public DIgitalStoreMessagePushRequestMessageDataList setOutTraceId(String outTraceId) {
            this.outTraceId = outTraceId;
            return this;
        }
        public String getOutTraceId() {
            return this.outTraceId;
        }

        public DIgitalStoreMessagePushRequestMessageDataList setSceneCardCode(String sceneCardCode) {
            this.sceneCardCode = sceneCardCode;
            return this;
        }
        public String getSceneCardCode() {
            return this.sceneCardCode;
        }

        public DIgitalStoreMessagePushRequestMessageDataList setSceneScope(Long sceneScope) {
            this.sceneScope = sceneScope;
            return this;
        }
        public Long getSceneScope() {
            return this.sceneScope;
        }

        public DIgitalStoreMessagePushRequestMessageDataList setSendNow(Boolean sendNow) {
            this.sendNow = sendNow;
            return this;
        }
        public Boolean getSendNow() {
            return this.sendNow;
        }

    }

}
