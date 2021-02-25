// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class AuthUrlResponseBody extends TeaModel {
    @NameInMap("data")
    public AuthUrlResponseBodyData data;

    @NameInMap("code")
    public Integer code;

    @NameInMap("message")
    public String message;

    public static AuthUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AuthUrlResponseBody self = new AuthUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public AuthUrlResponseBody setData(AuthUrlResponseBodyData data) {
        this.data = data;
        return this;
    }
    public AuthUrlResponseBodyData getData() {
        return this.data;
    }

    public AuthUrlResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public AuthUrlResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class AuthUrlResponseBodyData extends TeaModel {
        @NameInMap("taskId")
        public String taskId;

        @NameInMap("mobileUrl")
        public String mobileUrl;

        @NameInMap("pcUrl")
        public String pcUrl;

        public static AuthUrlResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            AuthUrlResponseBodyData self = new AuthUrlResponseBodyData();
            return TeaModel.build(map, self);
        }

        public AuthUrlResponseBodyData setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public AuthUrlResponseBodyData setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public AuthUrlResponseBodyData setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

    }

}
