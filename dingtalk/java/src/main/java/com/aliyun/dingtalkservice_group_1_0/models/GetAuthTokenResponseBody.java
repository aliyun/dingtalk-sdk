// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetAuthTokenResponseBody extends TeaModel {
    @NameInMap("dingOpenErrcode")
    public Integer dingOpenErrcode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public GetAuthTokenResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetAuthTokenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAuthTokenResponseBody self = new GetAuthTokenResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAuthTokenResponseBody setDingOpenErrcode(Integer dingOpenErrcode) {
        this.dingOpenErrcode = dingOpenErrcode;
        return this;
    }
    public Integer getDingOpenErrcode() {
        return this.dingOpenErrcode;
    }

    public GetAuthTokenResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public GetAuthTokenResponseBody setResult(GetAuthTokenResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetAuthTokenResponseBodyResult getResult() {
        return this.result;
    }

    public GetAuthTokenResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetAuthTokenResponseBodyResult extends TeaModel {
        @NameInMap("authToken")
        public String authToken;

        @NameInMap("channel")
        public String channel;

        @NameInMap("effectiveTime")
        public Long effectiveTime;

        @NameInMap("serverId")
        public String serverId;

        @NameInMap("serverName")
        public String serverName;

        public static GetAuthTokenResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetAuthTokenResponseBodyResult self = new GetAuthTokenResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetAuthTokenResponseBodyResult setAuthToken(String authToken) {
            this.authToken = authToken;
            return this;
        }
        public String getAuthToken() {
            return this.authToken;
        }

        public GetAuthTokenResponseBodyResult setChannel(String channel) {
            this.channel = channel;
            return this;
        }
        public String getChannel() {
            return this.channel;
        }

        public GetAuthTokenResponseBodyResult setEffectiveTime(Long effectiveTime) {
            this.effectiveTime = effectiveTime;
            return this;
        }
        public Long getEffectiveTime() {
            return this.effectiveTime;
        }

        public GetAuthTokenResponseBodyResult setServerId(String serverId) {
            this.serverId = serverId;
            return this;
        }
        public String getServerId() {
            return this.serverId;
        }

        public GetAuthTokenResponseBodyResult setServerName(String serverName) {
            this.serverName = serverName;
            return this;
        }
        public String getServerName() {
            return this.serverName;
        }

    }

}
