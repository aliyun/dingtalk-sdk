// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CreateAutoLoginUrlResponseBody extends TeaModel {
    @NameInMap("loginInfo")
    public CreateAutoLoginUrlResponseBodyLoginInfo loginInfo;

    @NameInMap("success")
    public Boolean success;

    public static CreateAutoLoginUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateAutoLoginUrlResponseBody self = new CreateAutoLoginUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateAutoLoginUrlResponseBody setLoginInfo(CreateAutoLoginUrlResponseBodyLoginInfo loginInfo) {
        this.loginInfo = loginInfo;
        return this;
    }
    public CreateAutoLoginUrlResponseBodyLoginInfo getLoginInfo() {
        return this.loginInfo;
    }

    public CreateAutoLoginUrlResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateAutoLoginUrlResponseBodyLoginInfo extends TeaModel {
        @NameInMap("loginUrl")
        public String loginUrl;

        public static CreateAutoLoginUrlResponseBodyLoginInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateAutoLoginUrlResponseBodyLoginInfo self = new CreateAutoLoginUrlResponseBodyLoginInfo();
            return TeaModel.build(map, self);
        }

        public CreateAutoLoginUrlResponseBodyLoginInfo setLoginUrl(String loginUrl) {
            this.loginUrl = loginUrl;
            return this;
        }
        public String getLoginUrl() {
            return this.loginUrl;
        }

    }

}
