// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class ListActivateDevicesResponseBody extends TeaModel {
    @NameInMap("totalCount")
    public Long totalCount;

    @NameInMap("success")
    public Boolean success;

    @NameInMap("result")
    public java.util.List<ListActivateDevicesResponseBodyResult> result;

    public static ListActivateDevicesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListActivateDevicesResponseBody self = new ListActivateDevicesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListActivateDevicesResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public ListActivateDevicesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public ListActivateDevicesResponseBody setResult(java.util.List<ListActivateDevicesResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListActivateDevicesResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ListActivateDevicesResponseBodyResult extends TeaModel {
        @NameInMap("bizExt")
        public String bizExt;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("deviceCallbackUrl")
        public String deviceCallbackUrl;

        @NameInMap("deviceCode")
        public String deviceCode;

        @NameInMap("deviceDetailUrl")
        public String deviceDetailUrl;

        @NameInMap("deviceName")
        public String deviceName;

        @NameInMap("groupUuid")
        public String groupUuid;

        @NameInMap("icon")
        public String icon;

        @NameInMap("introduction")
        public String introduction;

        @NameInMap("typeUuid")
        public String typeUuid;

        @NameInMap("uuid")
        public String uuid;

        public static ListActivateDevicesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListActivateDevicesResponseBodyResult self = new ListActivateDevicesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListActivateDevicesResponseBodyResult setBizExt(String bizExt) {
            this.bizExt = bizExt;
            return this;
        }
        public String getBizExt() {
            return this.bizExt;
        }

        public ListActivateDevicesResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ListActivateDevicesResponseBodyResult setDeviceCallbackUrl(String deviceCallbackUrl) {
            this.deviceCallbackUrl = deviceCallbackUrl;
            return this;
        }
        public String getDeviceCallbackUrl() {
            return this.deviceCallbackUrl;
        }

        public ListActivateDevicesResponseBodyResult setDeviceCode(String deviceCode) {
            this.deviceCode = deviceCode;
            return this;
        }
        public String getDeviceCode() {
            return this.deviceCode;
        }

        public ListActivateDevicesResponseBodyResult setDeviceDetailUrl(String deviceDetailUrl) {
            this.deviceDetailUrl = deviceDetailUrl;
            return this;
        }
        public String getDeviceDetailUrl() {
            return this.deviceDetailUrl;
        }

        public ListActivateDevicesResponseBodyResult setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public ListActivateDevicesResponseBodyResult setGroupUuid(String groupUuid) {
            this.groupUuid = groupUuid;
            return this;
        }
        public String getGroupUuid() {
            return this.groupUuid;
        }

        public ListActivateDevicesResponseBodyResult setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListActivateDevicesResponseBodyResult setIntroduction(String introduction) {
            this.introduction = introduction;
            return this;
        }
        public String getIntroduction() {
            return this.introduction;
        }

        public ListActivateDevicesResponseBodyResult setTypeUuid(String typeUuid) {
            this.typeUuid = typeUuid;
            return this;
        }
        public String getTypeUuid() {
            return this.typeUuid;
        }

        public ListActivateDevicesResponseBodyResult setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

    }

}
