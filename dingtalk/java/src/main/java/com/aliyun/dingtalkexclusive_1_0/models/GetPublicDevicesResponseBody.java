// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPublicDevicesResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<GetPublicDevicesResponseBodyData> data;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("dataCnt")
    public Integer dataCnt;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("totalCnt")
    public Long totalCnt;

    public static GetPublicDevicesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPublicDevicesResponseBody self = new GetPublicDevicesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPublicDevicesResponseBody setData(java.util.List<GetPublicDevicesResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetPublicDevicesResponseBodyData> getData() {
        return this.data;
    }

    public GetPublicDevicesResponseBody setDataCnt(Integer dataCnt) {
        this.dataCnt = dataCnt;
        return this;
    }
    public Integer getDataCnt() {
        return this.dataCnt;
    }

    public GetPublicDevicesResponseBody setTotalCnt(Long totalCnt) {
        this.totalCnt = totalCnt;
        return this;
    }
    public Long getTotalCnt() {
        return this.totalCnt;
    }

    public static class GetPublicDevicesResponseBodyDataDeviceDepts extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <strong>example:</strong>
         * <p>测试部门</p>
         */
        @NameInMap("name")
        public String name;

        public static GetPublicDevicesResponseBodyDataDeviceDepts build(java.util.Map<String, ?> map) throws Exception {
            GetPublicDevicesResponseBodyDataDeviceDepts self = new GetPublicDevicesResponseBodyDataDeviceDepts();
            return TeaModel.build(map, self);
        }

        public GetPublicDevicesResponseBodyDataDeviceDepts setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GetPublicDevicesResponseBodyDataDeviceDepts setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class GetPublicDevicesResponseBodyDataDeviceRoles extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>测试角色</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("tagCode")
        public String tagCode;

        public static GetPublicDevicesResponseBodyDataDeviceRoles build(java.util.Map<String, ?> map) throws Exception {
            GetPublicDevicesResponseBodyDataDeviceRoles self = new GetPublicDevicesResponseBodyDataDeviceRoles();
            return TeaModel.build(map, self);
        }

        public GetPublicDevicesResponseBodyDataDeviceRoles setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetPublicDevicesResponseBodyDataDeviceRoles setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

    }

    public static class GetPublicDevicesResponseBodyDataDeviceStaffs extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GetPublicDevicesResponseBodyDataDeviceStaffs build(java.util.Map<String, ?> map) throws Exception {
            GetPublicDevicesResponseBodyDataDeviceStaffs self = new GetPublicDevicesResponseBodyDataDeviceStaffs();
            return TeaModel.build(map, self);
        }

        public GetPublicDevicesResponseBodyDataDeviceStaffs setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetPublicDevicesResponseBodyDataDeviceStaffs setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetPublicDevicesResponseBodyData extends TeaModel {
        @NameInMap("deviceDepts")
        public java.util.List<GetPublicDevicesResponseBodyDataDeviceDepts> deviceDepts;

        @NameInMap("deviceRoles")
        public java.util.List<GetPublicDevicesResponseBodyDataDeviceRoles> deviceRoles;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("deviceScopeType")
        public Integer deviceScopeType;

        @NameInMap("deviceStaffs")
        public java.util.List<GetPublicDevicesResponseBodyDataDeviceStaffs> deviceStaffs;

        @NameInMap("deviceUuid")
        public String deviceUuid;

        /**
         * <strong>example:</strong>
         * <p>1671767361000</p>
         */
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        /**
         * <strong>example:</strong>
         * <p>1671767361000</p>
         */
        @NameInMap("gmtModified")
        public Long gmtModified;

        /**
         * <strong>example:</strong>
         * <p>88:66:5a:07:2b:04</p>
         */
        @NameInMap("macAddress")
        public String macAddress;

        /**
         * <strong>example:</strong>
         * <p>Mac</p>
         */
        @NameInMap("platform")
        public String platform;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("retryPermission")
        public String retryPermission;

        @NameInMap("serialNumber")
        public String serialNumber;

        @NameInMap("status")
        public Integer status;

        /**
         * <strong>example:</strong>
         * <p>这是标题</p>
         */
        @NameInMap("title")
        public String title;

        public static GetPublicDevicesResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetPublicDevicesResponseBodyData self = new GetPublicDevicesResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetPublicDevicesResponseBodyData setDeviceDepts(java.util.List<GetPublicDevicesResponseBodyDataDeviceDepts> deviceDepts) {
            this.deviceDepts = deviceDepts;
            return this;
        }
        public java.util.List<GetPublicDevicesResponseBodyDataDeviceDepts> getDeviceDepts() {
            return this.deviceDepts;
        }

        public GetPublicDevicesResponseBodyData setDeviceRoles(java.util.List<GetPublicDevicesResponseBodyDataDeviceRoles> deviceRoles) {
            this.deviceRoles = deviceRoles;
            return this;
        }
        public java.util.List<GetPublicDevicesResponseBodyDataDeviceRoles> getDeviceRoles() {
            return this.deviceRoles;
        }

        public GetPublicDevicesResponseBodyData setDeviceScopeType(Integer deviceScopeType) {
            this.deviceScopeType = deviceScopeType;
            return this;
        }
        public Integer getDeviceScopeType() {
            return this.deviceScopeType;
        }

        public GetPublicDevicesResponseBodyData setDeviceStaffs(java.util.List<GetPublicDevicesResponseBodyDataDeviceStaffs> deviceStaffs) {
            this.deviceStaffs = deviceStaffs;
            return this;
        }
        public java.util.List<GetPublicDevicesResponseBodyDataDeviceStaffs> getDeviceStaffs() {
            return this.deviceStaffs;
        }

        public GetPublicDevicesResponseBodyData setDeviceUuid(String deviceUuid) {
            this.deviceUuid = deviceUuid;
            return this;
        }
        public String getDeviceUuid() {
            return this.deviceUuid;
        }

        public GetPublicDevicesResponseBodyData setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public GetPublicDevicesResponseBodyData setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public GetPublicDevicesResponseBodyData setMacAddress(String macAddress) {
            this.macAddress = macAddress;
            return this;
        }
        public String getMacAddress() {
            return this.macAddress;
        }

        public GetPublicDevicesResponseBodyData setPlatform(String platform) {
            this.platform = platform;
            return this;
        }
        public String getPlatform() {
            return this.platform;
        }

        public GetPublicDevicesResponseBodyData setRetryPermission(String retryPermission) {
            this.retryPermission = retryPermission;
            return this;
        }
        public String getRetryPermission() {
            return this.retryPermission;
        }

        public GetPublicDevicesResponseBodyData setSerialNumber(String serialNumber) {
            this.serialNumber = serialNumber;
            return this;
        }
        public String getSerialNumber() {
            return this.serialNumber;
        }

        public GetPublicDevicesResponseBodyData setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public GetPublicDevicesResponseBodyData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
