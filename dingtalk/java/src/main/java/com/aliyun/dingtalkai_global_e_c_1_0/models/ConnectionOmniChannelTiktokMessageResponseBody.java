// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class ConnectionOmniChannelTiktokMessageResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("omniChannelTiktokRsp")
    public ConnectionOmniChannelTiktokMessageResponseBodyOmniChannelTiktokRsp omniChannelTiktokRsp;

    @NameInMap("success")
    public String success;

    public static ConnectionOmniChannelTiktokMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ConnectionOmniChannelTiktokMessageResponseBody self = new ConnectionOmniChannelTiktokMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public ConnectionOmniChannelTiktokMessageResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public ConnectionOmniChannelTiktokMessageResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public ConnectionOmniChannelTiktokMessageResponseBody setOmniChannelTiktokRsp(ConnectionOmniChannelTiktokMessageResponseBodyOmniChannelTiktokRsp omniChannelTiktokRsp) {
        this.omniChannelTiktokRsp = omniChannelTiktokRsp;
        return this;
    }
    public ConnectionOmniChannelTiktokMessageResponseBodyOmniChannelTiktokRsp getOmniChannelTiktokRsp() {
        return this.omniChannelTiktokRsp;
    }

    public ConnectionOmniChannelTiktokMessageResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class ConnectionOmniChannelTiktokMessageResponseBodyOmniChannelTiktokRsp extends TeaModel {
        @NameInMap("code")
        public String code;

        public static ConnectionOmniChannelTiktokMessageResponseBodyOmniChannelTiktokRsp build(java.util.Map<String, ?> map) throws Exception {
            ConnectionOmniChannelTiktokMessageResponseBodyOmniChannelTiktokRsp self = new ConnectionOmniChannelTiktokMessageResponseBodyOmniChannelTiktokRsp();
            return TeaModel.build(map, self);
        }

        public ConnectionOmniChannelTiktokMessageResponseBodyOmniChannelTiktokRsp setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

    }

}
