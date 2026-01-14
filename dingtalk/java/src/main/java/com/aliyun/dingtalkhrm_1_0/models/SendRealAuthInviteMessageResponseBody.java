// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SendRealAuthInviteMessageResponseBody extends TeaModel {
    @NameInMap("dingOpenErrcode")
    public Integer dingOpenErrcode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public SendRealAuthInviteMessageResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static SendRealAuthInviteMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendRealAuthInviteMessageResponseBody self = new SendRealAuthInviteMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public SendRealAuthInviteMessageResponseBody setDingOpenErrcode(Integer dingOpenErrcode) {
        this.dingOpenErrcode = dingOpenErrcode;
        return this;
    }
    public Integer getDingOpenErrcode() {
        return this.dingOpenErrcode;
    }

    public SendRealAuthInviteMessageResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public SendRealAuthInviteMessageResponseBody setResult(SendRealAuthInviteMessageResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SendRealAuthInviteMessageResponseBodyResult getResult() {
        return this.result;
    }

    public SendRealAuthInviteMessageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SendRealAuthInviteMessageResponseBodyResult extends TeaModel {
        @NameInMap("hadInvitedNum")
        public Integer hadInvitedNum;

        @NameInMap("hadRealAuthNum")
        public Integer hadRealAuthNum;

        @NameInMap("successNum")
        public Integer successNum;

        public static SendRealAuthInviteMessageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SendRealAuthInviteMessageResponseBodyResult self = new SendRealAuthInviteMessageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SendRealAuthInviteMessageResponseBodyResult setHadInvitedNum(Integer hadInvitedNum) {
            this.hadInvitedNum = hadInvitedNum;
            return this;
        }
        public Integer getHadInvitedNum() {
            return this.hadInvitedNum;
        }

        public SendRealAuthInviteMessageResponseBodyResult setHadRealAuthNum(Integer hadRealAuthNum) {
            this.hadRealAuthNum = hadRealAuthNum;
            return this;
        }
        public Integer getHadRealAuthNum() {
            return this.hadRealAuthNum;
        }

        public SendRealAuthInviteMessageResponseBodyResult setSuccessNum(Integer successNum) {
            this.successNum = successNum;
            return this;
        }
        public Integer getSuccessNum() {
            return this.successNum;
        }

    }

}
