// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SendRealAuthInviteMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("inviterId")
    public String inviterId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("onWorkingEmpSearchVO")
    public SendRealAuthInviteMessageRequestOnWorkingEmpSearchVO onWorkingEmpSearchVO;

    public static SendRealAuthInviteMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendRealAuthInviteMessageRequest self = new SendRealAuthInviteMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendRealAuthInviteMessageRequest setInviterId(String inviterId) {
        this.inviterId = inviterId;
        return this;
    }
    public String getInviterId() {
        return this.inviterId;
    }

    public SendRealAuthInviteMessageRequest setOnWorkingEmpSearchVO(SendRealAuthInviteMessageRequestOnWorkingEmpSearchVO onWorkingEmpSearchVO) {
        this.onWorkingEmpSearchVO = onWorkingEmpSearchVO;
        return this;
    }
    public SendRealAuthInviteMessageRequestOnWorkingEmpSearchVO getOnWorkingEmpSearchVO() {
        return this.onWorkingEmpSearchVO;
    }

    public static class SendRealAuthInviteMessageRequestOnWorkingEmpSearchVO extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userIds")
        public java.util.List<String> userIds;

        public static SendRealAuthInviteMessageRequestOnWorkingEmpSearchVO build(java.util.Map<String, ?> map) throws Exception {
            SendRealAuthInviteMessageRequestOnWorkingEmpSearchVO self = new SendRealAuthInviteMessageRequestOnWorkingEmpSearchVO();
            return TeaModel.build(map, self);
        }

        public SendRealAuthInviteMessageRequestOnWorkingEmpSearchVO setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

    }

}
