// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetCropStatusResponseBody extends TeaModel {
    @NameInMap("data")
    public GetCropStatusResponseBodyData data;

    @NameInMap("code")
    public Integer code;

    @NameInMap("message")
    public String message;

    public static GetCropStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCropStatusResponseBody self = new GetCropStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCropStatusResponseBody setData(GetCropStatusResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetCropStatusResponseBodyData getData() {
        return this.data;
    }

    public GetCropStatusResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public GetCropStatusResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GetCropStatusResponseBodyData extends TeaModel {
        @NameInMap("authStatus")
        public String authStatus;

        @NameInMap("installStatus")
        public String installStatus;

        public static GetCropStatusResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetCropStatusResponseBodyData self = new GetCropStatusResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetCropStatusResponseBodyData setAuthStatus(String authStatus) {
            this.authStatus = authStatus;
            return this;
        }
        public String getAuthStatus() {
            return this.authStatus;
        }

        public GetCropStatusResponseBodyData setInstallStatus(String installStatus) {
            this.installStatus = installStatus;
            return this;
        }
        public String getInstallStatus() {
            return this.installStatus;
        }

    }

}
