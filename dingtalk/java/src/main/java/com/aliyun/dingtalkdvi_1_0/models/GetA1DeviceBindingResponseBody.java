// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetA1DeviceBindingResponseBody extends TeaModel {
    @NameInMap("result")
    public GetA1DeviceBindingResponseBodyResult result;

    public static GetA1DeviceBindingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetA1DeviceBindingResponseBody self = new GetA1DeviceBindingResponseBody();
        return TeaModel.build(map, self);
    }

    public GetA1DeviceBindingResponseBody setResult(GetA1DeviceBindingResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetA1DeviceBindingResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetA1DeviceBindingResponseBodyResultBinding extends TeaModel {
        @NameInMap("bindTimestamp")
        public Long bindTimestamp;

        @NameInMap("bindingStatus")
        public String bindingStatus;

        @NameInMap("sn")
        public String sn;

        @NameInMap("unionId")
        public String unionId;

        public static GetA1DeviceBindingResponseBodyResultBinding build(java.util.Map<String, ?> map) throws Exception {
            GetA1DeviceBindingResponseBodyResultBinding self = new GetA1DeviceBindingResponseBodyResultBinding();
            return TeaModel.build(map, self);
        }

        public GetA1DeviceBindingResponseBodyResultBinding setBindTimestamp(Long bindTimestamp) {
            this.bindTimestamp = bindTimestamp;
            return this;
        }
        public Long getBindTimestamp() {
            return this.bindTimestamp;
        }

        public GetA1DeviceBindingResponseBodyResultBinding setBindingStatus(String bindingStatus) {
            this.bindingStatus = bindingStatus;
            return this;
        }
        public String getBindingStatus() {
            return this.bindingStatus;
        }

        public GetA1DeviceBindingResponseBodyResultBinding setSn(String sn) {
            this.sn = sn;
            return this;
        }
        public String getSn() {
            return this.sn;
        }

        public GetA1DeviceBindingResponseBodyResultBinding setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class GetA1DeviceBindingResponseBodyResult extends TeaModel {
        @NameInMap("binding")
        public GetA1DeviceBindingResponseBodyResultBinding binding;

        public static GetA1DeviceBindingResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetA1DeviceBindingResponseBodyResult self = new GetA1DeviceBindingResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetA1DeviceBindingResponseBodyResult setBinding(GetA1DeviceBindingResponseBodyResultBinding binding) {
            this.binding = binding;
            return this;
        }
        public GetA1DeviceBindingResponseBodyResultBinding getBinding() {
            return this.binding;
        }

    }

}
