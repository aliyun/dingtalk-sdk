// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class DeliverCardWithDelegateResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<DeliverCardWithDelegateResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static DeliverCardWithDelegateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeliverCardWithDelegateResponseBody self = new DeliverCardWithDelegateResponseBody();
        return TeaModel.build(map, self);
    }

    public DeliverCardWithDelegateResponseBody setResult(java.util.List<DeliverCardWithDelegateResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<DeliverCardWithDelegateResponseBodyResult> getResult() {
        return this.result;
    }

    public DeliverCardWithDelegateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DeliverCardWithDelegateResponseBodyResult extends TeaModel {
        @NameInMap("carrierId")
        public String carrierId;

        @NameInMap("errorMsg")
        public String errorMsg;

        @NameInMap("spaceId")
        public String spaceId;

        @NameInMap("spaceType")
        public String spaceType;

        @NameInMap("success")
        public Boolean success;

        public static DeliverCardWithDelegateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DeliverCardWithDelegateResponseBodyResult self = new DeliverCardWithDelegateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DeliverCardWithDelegateResponseBodyResult setCarrierId(String carrierId) {
            this.carrierId = carrierId;
            return this;
        }
        public String getCarrierId() {
            return this.carrierId;
        }

        public DeliverCardWithDelegateResponseBodyResult setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public DeliverCardWithDelegateResponseBodyResult setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public DeliverCardWithDelegateResponseBodyResult setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

        public DeliverCardWithDelegateResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
