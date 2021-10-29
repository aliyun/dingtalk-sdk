// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateInviteUrlResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    @NameInMap("result")
    public CreateInviteUrlResponseBodyResult result;

    public static CreateInviteUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateInviteUrlResponseBody self = new CreateInviteUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateInviteUrlResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public CreateInviteUrlResponseBody setResult(CreateInviteUrlResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateInviteUrlResponseBodyResult getResult() {
        return this.result;
    }

    public static class CreateInviteUrlResponseBodyResult extends TeaModel {
        @NameInMap("inviteUrl")
        public String inviteUrl;

        public static CreateInviteUrlResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateInviteUrlResponseBodyResult self = new CreateInviteUrlResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateInviteUrlResponseBodyResult setInviteUrl(String inviteUrl) {
            this.inviteUrl = inviteUrl;
            return this;
        }
        public String getInviteUrl() {
            return this.inviteUrl;
        }

    }

}
