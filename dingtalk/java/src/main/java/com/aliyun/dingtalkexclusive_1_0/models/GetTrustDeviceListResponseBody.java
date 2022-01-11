// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetTrustDeviceListResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<GetTrustDeviceListResponseBodyData> data;

    public static GetTrustDeviceListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTrustDeviceListResponseBody self = new GetTrustDeviceListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTrustDeviceListResponseBody setData(java.util.List<GetTrustDeviceListResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetTrustDeviceListResponseBodyData> getData() {
        return this.data;
    }

    public static class GetTrustDeviceListResponseBodyData extends TeaModel {
        // 创建时间
        @NameInMap("createTime")
        public Long createTime;

        // mac地址
        @NameInMap("macAddress")
        public String macAddress;

        // 平台类型
        @NameInMap("platform")
        public String platform;

        // 设备状态
        @NameInMap("status")
        public Integer status;

        // 员工Id
        @NameInMap("userId")
        public String userId;

        public static GetTrustDeviceListResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetTrustDeviceListResponseBodyData self = new GetTrustDeviceListResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetTrustDeviceListResponseBodyData setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public GetTrustDeviceListResponseBodyData setMacAddress(String macAddress) {
            this.macAddress = macAddress;
            return this;
        }
        public String getMacAddress() {
            return this.macAddress;
        }

        public GetTrustDeviceListResponseBodyData setPlatform(String platform) {
            this.platform = platform;
            return this;
        }
        public String getPlatform() {
            return this.platform;
        }

        public GetTrustDeviceListResponseBodyData setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public GetTrustDeviceListResponseBodyData setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
