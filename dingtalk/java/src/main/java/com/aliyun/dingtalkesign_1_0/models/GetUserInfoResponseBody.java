// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetUserInfoResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public GetUserInfoResponseBodyData data;

    @NameInMap("message")
    public String message;

    public static GetUserInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserInfoResponseBody self = new GetUserInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserInfoResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public GetUserInfoResponseBody setData(GetUserInfoResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetUserInfoResponseBodyData getData() {
        return this.data;
    }

    public GetUserInfoResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GetUserInfoResponseBodyData extends TeaModel {
        @NameInMap("realName")
        public Boolean realName;

        @NameInMap("userRealName")
        public String userRealName;

        public static GetUserInfoResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetUserInfoResponseBodyData self = new GetUserInfoResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetUserInfoResponseBodyData setRealName(Boolean realName) {
            this.realName = realName;
            return this;
        }
        public Boolean getRealName() {
            return this.realName;
        }

        public GetUserInfoResponseBodyData setUserRealName(String userRealName) {
            this.userRealName = userRealName;
            return this;
        }
        public String getUserRealName() {
            return this.userRealName;
        }

    }

}
