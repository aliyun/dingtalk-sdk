// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomDeviceResponseBody extends TeaModel {
    /**
     * <p>响应结果</p>
     */
    @NameInMap("result")
    public QueryMeetingRoomDeviceResponseBodyResult result;

    public static QueryMeetingRoomDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomDeviceResponseBody self = new QueryMeetingRoomDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomDeviceResponseBody setResult(QueryMeetingRoomDeviceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryMeetingRoomDeviceResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryMeetingRoomDeviceResponseBodyResultControllers extends TeaModel {
        /**
         * <p>企业corpId</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>控制器设备id</p>
         */
        @NameInMap("deviceId")
        public String deviceId;

        /**
         * <p>控制器mac地址</p>
         */
        @NameInMap("deviceMac")
        public String deviceMac;

        /**
         * <p>控制器型号</p>
         */
        @NameInMap("deviceModel")
        public String deviceModel;

        /**
         * <p>控制器名称</p>
         */
        @NameInMap("deviceName")
        public String deviceName;

        /**
         * <p>控制器注册serviceId</p>
         */
        @NameInMap("deviceServiceId")
        public Integer deviceServiceId;

        /**
         * <p>控制器sn</p>
         */
        @NameInMap("deviceSn")
        public String deviceSn;

        /**
         * <p>控制器状态</p>
         */
        @NameInMap("deviceStatus")
        public String deviceStatus;

        /**
         * <p>设备类型</p>
         */
        @NameInMap("deviceType")
        public String deviceType;

        /**
         * <p>控制器unionId</p>
         */
        @NameInMap("deviceUnionId")
        public String deviceUnionId;

        /**
         * <p>控制器绑定会议室id</p>
         */
        @NameInMap("openRoomId")
        public String openRoomId;

        /**
         * <p>控制器投屏码</p>
         */
        @NameInMap("shareCode")
        public String shareCode;

        public static QueryMeetingRoomDeviceResponseBodyResultControllers build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomDeviceResponseBodyResultControllers self = new QueryMeetingRoomDeviceResponseBodyResultControllers();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceId(String deviceId) {
            this.deviceId = deviceId;
            return this;
        }
        public String getDeviceId() {
            return this.deviceId;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceMac(String deviceMac) {
            this.deviceMac = deviceMac;
            return this;
        }
        public String getDeviceMac() {
            return this.deviceMac;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceModel(String deviceModel) {
            this.deviceModel = deviceModel;
            return this;
        }
        public String getDeviceModel() {
            return this.deviceModel;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceServiceId(Integer deviceServiceId) {
            this.deviceServiceId = deviceServiceId;
            return this;
        }
        public Integer getDeviceServiceId() {
            return this.deviceServiceId;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceSn(String deviceSn) {
            this.deviceSn = deviceSn;
            return this;
        }
        public String getDeviceSn() {
            return this.deviceSn;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceStatus(String deviceStatus) {
            this.deviceStatus = deviceStatus;
            return this;
        }
        public String getDeviceStatus() {
            return this.deviceStatus;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceType(String deviceType) {
            this.deviceType = deviceType;
            return this;
        }
        public String getDeviceType() {
            return this.deviceType;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceUnionId(String deviceUnionId) {
            this.deviceUnionId = deviceUnionId;
            return this;
        }
        public String getDeviceUnionId() {
            return this.deviceUnionId;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setOpenRoomId(String openRoomId) {
            this.openRoomId = openRoomId;
            return this;
        }
        public String getOpenRoomId() {
            return this.openRoomId;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setShareCode(String shareCode) {
            this.shareCode = shareCode;
            return this;
        }
        public String getShareCode() {
            return this.shareCode;
        }

    }

    public static class QueryMeetingRoomDeviceResponseBodyResult extends TeaModel {
        /**
         * <p>设备控制器</p>
         */
        @NameInMap("controllers")
        public java.util.List<QueryMeetingRoomDeviceResponseBodyResultControllers> controllers;

        /**
         * <p>企业corpId</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>设备id</p>
         */
        @NameInMap("deviceId")
        public String deviceId;

        /**
         * <p>设备mac地址</p>
         */
        @NameInMap("deviceMac")
        public String deviceMac;

        /**
         * <p>设备型号</p>
         */
        @NameInMap("deviceModel")
        public String deviceModel;

        /**
         * <p>设备名称</p>
         */
        @NameInMap("deviceName")
        public String deviceName;

        /**
         * <p>设备注册serviceId</p>
         */
        @NameInMap("deviceServiceId")
        public Integer deviceServiceId;

        /**
         * <p>设备sn</p>
         */
        @NameInMap("deviceSn")
        public String deviceSn;

        /**
         * <p>设备状态</p>
         */
        @NameInMap("deviceStatus")
        public String deviceStatus;

        /**
         * <p>设备类型</p>
         */
        @NameInMap("deviceType")
        public String deviceType;

        /**
         * <p>设备unionId</p>
         */
        @NameInMap("deviceUnionId")
        public String deviceUnionId;

        /**
         * <p>设备绑定会议室id</p>
         */
        @NameInMap("openRoomId")
        public String openRoomId;

        /**
         * <p>设备投屏码</p>
         */
        @NameInMap("shareCode")
        public String shareCode;

        public static QueryMeetingRoomDeviceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomDeviceResponseBodyResult self = new QueryMeetingRoomDeviceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomDeviceResponseBodyResult setControllers(java.util.List<QueryMeetingRoomDeviceResponseBodyResultControllers> controllers) {
            this.controllers = controllers;
            return this;
        }
        public java.util.List<QueryMeetingRoomDeviceResponseBodyResultControllers> getControllers() {
            return this.controllers;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceId(String deviceId) {
            this.deviceId = deviceId;
            return this;
        }
        public String getDeviceId() {
            return this.deviceId;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceMac(String deviceMac) {
            this.deviceMac = deviceMac;
            return this;
        }
        public String getDeviceMac() {
            return this.deviceMac;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceModel(String deviceModel) {
            this.deviceModel = deviceModel;
            return this;
        }
        public String getDeviceModel() {
            return this.deviceModel;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceServiceId(Integer deviceServiceId) {
            this.deviceServiceId = deviceServiceId;
            return this;
        }
        public Integer getDeviceServiceId() {
            return this.deviceServiceId;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceSn(String deviceSn) {
            this.deviceSn = deviceSn;
            return this;
        }
        public String getDeviceSn() {
            return this.deviceSn;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceStatus(String deviceStatus) {
            this.deviceStatus = deviceStatus;
            return this;
        }
        public String getDeviceStatus() {
            return this.deviceStatus;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceType(String deviceType) {
            this.deviceType = deviceType;
            return this;
        }
        public String getDeviceType() {
            return this.deviceType;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceUnionId(String deviceUnionId) {
            this.deviceUnionId = deviceUnionId;
            return this;
        }
        public String getDeviceUnionId() {
            return this.deviceUnionId;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setOpenRoomId(String openRoomId) {
            this.openRoomId = openRoomId;
            return this;
        }
        public String getOpenRoomId() {
            return this.openRoomId;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setShareCode(String shareCode) {
            this.shareCode = shareCode;
            return this;
        }
        public String getShareCode() {
            return this.shareCode;
        }

    }

}
