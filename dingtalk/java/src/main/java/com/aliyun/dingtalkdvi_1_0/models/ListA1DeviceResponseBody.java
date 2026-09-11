// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ListA1DeviceResponseBody extends TeaModel {
    @NameInMap("result")
    public ListA1DeviceResponseBodyResult result;

    public static ListA1DeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListA1DeviceResponseBody self = new ListA1DeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public ListA1DeviceResponseBody setResult(ListA1DeviceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ListA1DeviceResponseBodyResult getResult() {
        return this.result;
    }

    public static class ListA1DeviceResponseBodyResultItems extends TeaModel {
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

        public static ListA1DeviceResponseBodyResultItems build(java.util.Map<String, ?> map) throws Exception {
            ListA1DeviceResponseBodyResultItems self = new ListA1DeviceResponseBodyResultItems();
            return TeaModel.build(map, self);
        }

        public ListA1DeviceResponseBodyResultItems setBindTimestamp(Long bindTimestamp) {
            this.bindTimestamp = bindTimestamp;
            return this;
        }
        public Long getBindTimestamp() {
            return this.bindTimestamp;
        }

        public ListA1DeviceResponseBodyResultItems setBindingStatus(String bindingStatus) {
            this.bindingStatus = bindingStatus;
            return this;
        }
        public String getBindingStatus() {
            return this.bindingStatus;
        }

        public ListA1DeviceResponseBodyResultItems setDeviceModel(String deviceModel) {
            this.deviceModel = deviceModel;
            return this;
        }
        public String getDeviceModel() {
            return this.deviceModel;
        }

        public ListA1DeviceResponseBodyResultItems setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public ListA1DeviceResponseBodyResultItems setSn(String sn) {
            this.sn = sn;
            return this;
        }
        public String getSn() {
            return this.sn;
        }

        public ListA1DeviceResponseBodyResultItems setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class ListA1DeviceResponseBodyResult extends TeaModel {
        @NameInMap("items")
        public java.util.List<ListA1DeviceResponseBodyResultItems> items;

        @NameInMap("nextToken")
        public String nextToken;

        public static ListA1DeviceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListA1DeviceResponseBodyResult self = new ListA1DeviceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListA1DeviceResponseBodyResult setItems(java.util.List<ListA1DeviceResponseBodyResultItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<ListA1DeviceResponseBodyResultItems> getItems() {
            return this.items;
        }

        public ListA1DeviceResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

    }

}
