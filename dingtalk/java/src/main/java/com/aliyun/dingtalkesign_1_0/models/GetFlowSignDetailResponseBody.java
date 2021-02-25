// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetFlowSignDetailResponseBody extends TeaModel {
    @NameInMap("data")
    public GetFlowSignDetailResponseBodyData data;

    @NameInMap("code")
    public Integer code;

    @NameInMap("message")
    public String message;

    public static GetFlowSignDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFlowSignDetailResponseBody self = new GetFlowSignDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFlowSignDetailResponseBody setData(GetFlowSignDetailResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetFlowSignDetailResponseBodyData getData() {
        return this.data;
    }

    public GetFlowSignDetailResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public GetFlowSignDetailResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GetFlowSignDetailResponseBodyDataSigners extends TeaModel {
        @NameInMap("signerName")
        public String signerName;

        @NameInMap("signStatus")
        public Integer signStatus;

        public static GetFlowSignDetailResponseBodyDataSigners build(java.util.Map<String, ?> map) throws Exception {
            GetFlowSignDetailResponseBodyDataSigners self = new GetFlowSignDetailResponseBodyDataSigners();
            return TeaModel.build(map, self);
        }

        public GetFlowSignDetailResponseBodyDataSigners setSignerName(String signerName) {
            this.signerName = signerName;
            return this;
        }
        public String getSignerName() {
            return this.signerName;
        }

        public GetFlowSignDetailResponseBodyDataSigners setSignStatus(Integer signStatus) {
            this.signStatus = signStatus;
            return this;
        }
        public Integer getSignStatus() {
            return this.signStatus;
        }

    }

    public static class GetFlowSignDetailResponseBodyData extends TeaModel {
        @NameInMap("businessSense")
        public String businessSense;

        @NameInMap("flowStatus")
        public Integer flowStatus;

        @NameInMap("signers")
        public java.util.List<GetFlowSignDetailResponseBodyDataSigners> signers;

        public static GetFlowSignDetailResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetFlowSignDetailResponseBodyData self = new GetFlowSignDetailResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetFlowSignDetailResponseBodyData setBusinessSense(String businessSense) {
            this.businessSense = businessSense;
            return this;
        }
        public String getBusinessSense() {
            return this.businessSense;
        }

        public GetFlowSignDetailResponseBodyData setFlowStatus(Integer flowStatus) {
            this.flowStatus = flowStatus;
            return this;
        }
        public Integer getFlowStatus() {
            return this.flowStatus;
        }

        public GetFlowSignDetailResponseBodyData setSigners(java.util.List<GetFlowSignDetailResponseBodyDataSigners> signers) {
            this.signers = signers;
            return this;
        }
        public java.util.List<GetFlowSignDetailResponseBodyDataSigners> getSigners() {
            return this.signers;
        }

    }

}
