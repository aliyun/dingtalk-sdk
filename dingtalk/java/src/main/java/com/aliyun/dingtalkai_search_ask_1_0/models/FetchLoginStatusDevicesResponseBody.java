// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_search_ask_1_0.models;

import com.aliyun.tea.*;

public class FetchLoginStatusDevicesResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public java.util.List<FetchLoginStatusDevicesResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static FetchLoginStatusDevicesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        FetchLoginStatusDevicesResponseBody self = new FetchLoginStatusDevicesResponseBody();
        return TeaModel.build(map, self);
    }

    public FetchLoginStatusDevicesResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public FetchLoginStatusDevicesResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public FetchLoginStatusDevicesResponseBody setResult(java.util.List<FetchLoginStatusDevicesResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<FetchLoginStatusDevicesResponseBodyResult> getResult() {
        return this.result;
    }

    public FetchLoginStatusDevicesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class FetchLoginStatusDevicesResponseBodyResultDeviceList extends TeaModel {
        @NameInMap("actionTimestamp")
        public Long actionTimestamp;

        @NameInMap("clientType")
        public String clientType;

        @NameInMap("isLoggedIn")
        public Boolean isLoggedIn;

        @NameInMap("openDeviceId")
        public String openDeviceId;

        public static FetchLoginStatusDevicesResponseBodyResultDeviceList build(java.util.Map<String, ?> map) throws Exception {
            FetchLoginStatusDevicesResponseBodyResultDeviceList self = new FetchLoginStatusDevicesResponseBodyResultDeviceList();
            return TeaModel.build(map, self);
        }

        public FetchLoginStatusDevicesResponseBodyResultDeviceList setActionTimestamp(Long actionTimestamp) {
            this.actionTimestamp = actionTimestamp;
            return this;
        }
        public Long getActionTimestamp() {
            return this.actionTimestamp;
        }

        public FetchLoginStatusDevicesResponseBodyResultDeviceList setClientType(String clientType) {
            this.clientType = clientType;
            return this;
        }
        public String getClientType() {
            return this.clientType;
        }

        public FetchLoginStatusDevicesResponseBodyResultDeviceList setIsLoggedIn(Boolean isLoggedIn) {
            this.isLoggedIn = isLoggedIn;
            return this;
        }
        public Boolean getIsLoggedIn() {
            return this.isLoggedIn;
        }

        public FetchLoginStatusDevicesResponseBodyResultDeviceList setOpenDeviceId(String openDeviceId) {
            this.openDeviceId = openDeviceId;
            return this;
        }
        public String getOpenDeviceId() {
            return this.openDeviceId;
        }

    }

    public static class FetchLoginStatusDevicesResponseBodyResult extends TeaModel {
        @NameInMap("deviceList")
        public java.util.List<FetchLoginStatusDevicesResponseBodyResultDeviceList> deviceList;

        @NameInMap("userId")
        public String userId;

        public static FetchLoginStatusDevicesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            FetchLoginStatusDevicesResponseBodyResult self = new FetchLoginStatusDevicesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public FetchLoginStatusDevicesResponseBodyResult setDeviceList(java.util.List<FetchLoginStatusDevicesResponseBodyResultDeviceList> deviceList) {
            this.deviceList = deviceList;
            return this;
        }
        public java.util.List<FetchLoginStatusDevicesResponseBodyResultDeviceList> getDeviceList() {
            return this.deviceList;
        }

        public FetchLoginStatusDevicesResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
