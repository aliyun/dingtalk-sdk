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
        /**
         * <p>创建时间</p>
         */
        @NameInMap("createTime")
        public Long createTime;

        /**
         * <p>mac地址</p>
         */
        @NameInMap("macAddress")
        public String macAddress;

        /**
         * <p>版本信息：Android端: Android,10，IOS端：iOS,12.0.1</p>
         */
        @NameInMap("model")
        public String model;

        /**
         * <p>平台类型</p>
         */
        @NameInMap("platform")
        public String platform;

        /**
         * <p>设备状态</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <p>设备名称</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>员工Id</p>
         */
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

        public GetTrustDeviceListResponseBodyData setModel(String model) {
            this.model = model;
            return this;
        }
        public String getModel() {
            return this.model;
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

        public GetTrustDeviceListResponseBodyData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
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
