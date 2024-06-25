// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateVoiceMsgCtrlStatusRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1-检测通过，2-检测失败</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("voiceMsgCtrlInfo")
    public UpdateVoiceMsgCtrlStatusRequestVoiceMsgCtrlInfo voiceMsgCtrlInfo;

    public static UpdateVoiceMsgCtrlStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateVoiceMsgCtrlStatusRequest self = new UpdateVoiceMsgCtrlStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateVoiceMsgCtrlStatusRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public UpdateVoiceMsgCtrlStatusRequest setVoiceMsgCtrlInfo(UpdateVoiceMsgCtrlStatusRequestVoiceMsgCtrlInfo voiceMsgCtrlInfo) {
        this.voiceMsgCtrlInfo = voiceMsgCtrlInfo;
        return this;
    }
    public UpdateVoiceMsgCtrlStatusRequestVoiceMsgCtrlInfo getVoiceMsgCtrlInfo() {
        return this.voiceMsgCtrlInfo;
    }

    public static class UpdateVoiceMsgCtrlStatusRequestVoiceMsgCtrlInfo extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("openMsgId")
        public String openMsgId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userId")
        public String userId;

        public static UpdateVoiceMsgCtrlStatusRequestVoiceMsgCtrlInfo build(java.util.Map<String, ?> map) throws Exception {
            UpdateVoiceMsgCtrlStatusRequestVoiceMsgCtrlInfo self = new UpdateVoiceMsgCtrlStatusRequestVoiceMsgCtrlInfo();
            return TeaModel.build(map, self);
        }

        public UpdateVoiceMsgCtrlStatusRequestVoiceMsgCtrlInfo setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public UpdateVoiceMsgCtrlStatusRequestVoiceMsgCtrlInfo setOpenMsgId(String openMsgId) {
            this.openMsgId = openMsgId;
            return this;
        }
        public String getOpenMsgId() {
            return this.openMsgId;
        }

        public UpdateVoiceMsgCtrlStatusRequestVoiceMsgCtrlInfo setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
