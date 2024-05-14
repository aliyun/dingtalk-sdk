// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetMachineResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public GetMachineResponseBodyResult result;

    public static GetMachineResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMachineResponseBody self = new GetMachineResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMachineResponseBody setResult(GetMachineResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetMachineResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetMachineResponseBodyResultMachineBluetoothVO extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("address")
        public String address;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bluetoothCheckWithFace")
        public Boolean bluetoothCheckWithFace;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bluetoothDistanceMode")
        public String bluetoothDistanceMode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bluetoothDistanceModeDesc")
        public String bluetoothDistanceModeDesc;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bluetoothValue")
        public Boolean bluetoothValue;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("latitude")
        public Double latitude;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("limitUserDeviceCount")
        public Boolean limitUserDeviceCount;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("longitude")
        public Double longitude;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("monitorLocationAbnormal")
        public Boolean monitorLocationAbnormal;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userDeviceCount")
        public Integer userDeviceCount;

        public static GetMachineResponseBodyResultMachineBluetoothVO build(java.util.Map<String, ?> map) throws Exception {
            GetMachineResponseBodyResultMachineBluetoothVO self = new GetMachineResponseBodyResultMachineBluetoothVO();
            return TeaModel.build(map, self);
        }

        public GetMachineResponseBodyResultMachineBluetoothVO setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public GetMachineResponseBodyResultMachineBluetoothVO setBluetoothCheckWithFace(Boolean bluetoothCheckWithFace) {
            this.bluetoothCheckWithFace = bluetoothCheckWithFace;
            return this;
        }
        public Boolean getBluetoothCheckWithFace() {
            return this.bluetoothCheckWithFace;
        }

        public GetMachineResponseBodyResultMachineBluetoothVO setBluetoothDistanceMode(String bluetoothDistanceMode) {
            this.bluetoothDistanceMode = bluetoothDistanceMode;
            return this;
        }
        public String getBluetoothDistanceMode() {
            return this.bluetoothDistanceMode;
        }

        public GetMachineResponseBodyResultMachineBluetoothVO setBluetoothDistanceModeDesc(String bluetoothDistanceModeDesc) {
            this.bluetoothDistanceModeDesc = bluetoothDistanceModeDesc;
            return this;
        }
        public String getBluetoothDistanceModeDesc() {
            return this.bluetoothDistanceModeDesc;
        }

        public GetMachineResponseBodyResultMachineBluetoothVO setBluetoothValue(Boolean bluetoothValue) {
            this.bluetoothValue = bluetoothValue;
            return this;
        }
        public Boolean getBluetoothValue() {
            return this.bluetoothValue;
        }

        public GetMachineResponseBodyResultMachineBluetoothVO setLatitude(Double latitude) {
            this.latitude = latitude;
            return this;
        }
        public Double getLatitude() {
            return this.latitude;
        }

        public GetMachineResponseBodyResultMachineBluetoothVO setLimitUserDeviceCount(Boolean limitUserDeviceCount) {
            this.limitUserDeviceCount = limitUserDeviceCount;
            return this;
        }
        public Boolean getLimitUserDeviceCount() {
            return this.limitUserDeviceCount;
        }

        public GetMachineResponseBodyResultMachineBluetoothVO setLongitude(Double longitude) {
            this.longitude = longitude;
            return this;
        }
        public Double getLongitude() {
            return this.longitude;
        }

        public GetMachineResponseBodyResultMachineBluetoothVO setMonitorLocationAbnormal(Boolean monitorLocationAbnormal) {
            this.monitorLocationAbnormal = monitorLocationAbnormal;
            return this;
        }
        public Boolean getMonitorLocationAbnormal() {
            return this.monitorLocationAbnormal;
        }

        public GetMachineResponseBodyResultMachineBluetoothVO setUserDeviceCount(Integer userDeviceCount) {
            this.userDeviceCount = userDeviceCount;
            return this;
        }
        public Integer getUserDeviceCount() {
            return this.userDeviceCount;
        }

    }

    public static class GetMachineResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("atmManagerList")
        public java.util.List<String> atmManagerList;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("devId")
        public Long devId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("deviceId")
        public String deviceId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("deviceName")
        public String deviceName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("deviceSn")
        public String deviceSn;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("machineBluetoothVO")
        public GetMachineResponseBodyResultMachineBluetoothVO machineBluetoothVO;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("maxFace")
        public Integer maxFace;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("netStatus")
        public String netStatus;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("productName")
        public String productName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("productVersion")
        public String productVersion;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("voiceMode")
        public Integer voiceMode;

        public static GetMachineResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetMachineResponseBodyResult self = new GetMachineResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetMachineResponseBodyResult setAtmManagerList(java.util.List<String> atmManagerList) {
            this.atmManagerList = atmManagerList;
            return this;
        }
        public java.util.List<String> getAtmManagerList() {
            return this.atmManagerList;
        }

        public GetMachineResponseBodyResult setDevId(Long devId) {
            this.devId = devId;
            return this;
        }
        public Long getDevId() {
            return this.devId;
        }

        public GetMachineResponseBodyResult setDeviceId(String deviceId) {
            this.deviceId = deviceId;
            return this;
        }
        public String getDeviceId() {
            return this.deviceId;
        }

        public GetMachineResponseBodyResult setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public GetMachineResponseBodyResult setDeviceSn(String deviceSn) {
            this.deviceSn = deviceSn;
            return this;
        }
        public String getDeviceSn() {
            return this.deviceSn;
        }

        public GetMachineResponseBodyResult setMachineBluetoothVO(GetMachineResponseBodyResultMachineBluetoothVO machineBluetoothVO) {
            this.machineBluetoothVO = machineBluetoothVO;
            return this;
        }
        public GetMachineResponseBodyResultMachineBluetoothVO getMachineBluetoothVO() {
            return this.machineBluetoothVO;
        }

        public GetMachineResponseBodyResult setMaxFace(Integer maxFace) {
            this.maxFace = maxFace;
            return this;
        }
        public Integer getMaxFace() {
            return this.maxFace;
        }

        public GetMachineResponseBodyResult setNetStatus(String netStatus) {
            this.netStatus = netStatus;
            return this;
        }
        public String getNetStatus() {
            return this.netStatus;
        }

        public GetMachineResponseBodyResult setProductName(String productName) {
            this.productName = productName;
            return this;
        }
        public String getProductName() {
            return this.productName;
        }

        public GetMachineResponseBodyResult setProductVersion(String productVersion) {
            this.productVersion = productVersion;
            return this;
        }
        public String getProductVersion() {
            return this.productVersion;
        }

        public GetMachineResponseBodyResult setVoiceMode(Integer voiceMode) {
            this.voiceMode = voiceMode;
            return this;
        }
        public Integer getVoiceMode() {
            return this.voiceMode;
        }

    }

}
