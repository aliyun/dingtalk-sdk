// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetA1DeviceDetailResponseBody extends TeaModel {
    @NameInMap("result")
    public GetA1DeviceDetailResponseBodyResult result;

    public static GetA1DeviceDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetA1DeviceDetailResponseBody self = new GetA1DeviceDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetA1DeviceDetailResponseBody setResult(GetA1DeviceDetailResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetA1DeviceDetailResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetA1DeviceDetailResponseBodyResultDevice extends TeaModel {
        @NameInMap("bindTimestamp")
        public Long bindTimestamp;

        @NameInMap("bindingStatus")
        public String bindingStatus;

        @NameInMap("deviceModel")
        public String deviceModel;

        @NameInMap("deviceName")
        public String deviceName;

        @NameInMap("sn")
        public String sn;

        @NameInMap("unionId")
        public String unionId;

        public static GetA1DeviceDetailResponseBodyResultDevice build(java.util.Map<String, ?> map) throws Exception {
            GetA1DeviceDetailResponseBodyResultDevice self = new GetA1DeviceDetailResponseBodyResultDevice();
            return TeaModel.build(map, self);
        }

        public GetA1DeviceDetailResponseBodyResultDevice setBindTimestamp(Long bindTimestamp) {
            this.bindTimestamp = bindTimestamp;
            return this;
        }
        public Long getBindTimestamp() {
            return this.bindTimestamp;
        }

        public GetA1DeviceDetailResponseBodyResultDevice setBindingStatus(String bindingStatus) {
            this.bindingStatus = bindingStatus;
            return this;
        }
        public String getBindingStatus() {
            return this.bindingStatus;
        }

        public GetA1DeviceDetailResponseBodyResultDevice setDeviceModel(String deviceModel) {
            this.deviceModel = deviceModel;
            return this;
        }
        public String getDeviceModel() {
            return this.deviceModel;
        }

        public GetA1DeviceDetailResponseBodyResultDevice setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public GetA1DeviceDetailResponseBodyResultDevice setSn(String sn) {
            this.sn = sn;
            return this;
        }
        public String getSn() {
            return this.sn;
        }

        public GetA1DeviceDetailResponseBodyResultDevice setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class GetA1DeviceDetailResponseBodyResult extends TeaModel {
        @NameInMap("device")
        public GetA1DeviceDetailResponseBodyResultDevice device;

        public static GetA1DeviceDetailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetA1DeviceDetailResponseBodyResult self = new GetA1DeviceDetailResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetA1DeviceDetailResponseBodyResult setDevice(GetA1DeviceDetailResponseBodyResultDevice device) {
            this.device = device;
            return this;
        }
        public GetA1DeviceDetailResponseBodyResultDevice getDevice() {
            return this.device;
        }

    }

}
