// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPublicDevicesResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<GetPublicDevicesResponseBodyData> data;

    @NameInMap("dataCnt")
    public Integer dataCnt;

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
        @NameInMap("id")
        public Long id;

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
        @NameInMap("name")
        public String name;

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
        @NameInMap("name")
        public String name;

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

        @NameInMap("deviceScopeType")
        public Integer deviceScopeType;

        @NameInMap("deviceStaffs")
        public java.util.List<GetPublicDevicesResponseBodyDataDeviceStaffs> deviceStaffs;

        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("macAddress")
        public String macAddress;

        @NameInMap("platform")
        public String platform;

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

        public GetPublicDevicesResponseBodyData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
