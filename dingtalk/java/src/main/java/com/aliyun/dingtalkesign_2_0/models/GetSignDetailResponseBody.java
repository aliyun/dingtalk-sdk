// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetSignDetailResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("businessScene")
    public String businessScene;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("flowStatus")
    public Float flowStatus;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("signers")
    public java.util.List<GetSignDetailResponseBodySigners> signers;

    public static GetSignDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSignDetailResponseBody self = new GetSignDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSignDetailResponseBody setBusinessScene(String businessScene) {
        this.businessScene = businessScene;
        return this;
    }
    public String getBusinessScene() {
        return this.businessScene;
    }

    public GetSignDetailResponseBody setFlowStatus(Float flowStatus) {
        this.flowStatus = flowStatus;
        return this;
    }
    public Float getFlowStatus() {
        return this.flowStatus;
    }

    public GetSignDetailResponseBody setSigners(java.util.List<GetSignDetailResponseBodySigners> signers) {
        this.signers = signers;
        return this;
    }
    public java.util.List<GetSignDetailResponseBodySigners> getSigners() {
        return this.signers;
    }

    public static class GetSignDetailResponseBodySigners extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("signStatus")
        public Float signStatus;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("signerName")
        public String signerName;

        public static GetSignDetailResponseBodySigners build(java.util.Map<String, ?> map) throws Exception {
            GetSignDetailResponseBodySigners self = new GetSignDetailResponseBodySigners();
            return TeaModel.build(map, self);
        }

        public GetSignDetailResponseBodySigners setSignStatus(Float signStatus) {
            this.signStatus = signStatus;
            return this;
        }
        public Float getSignStatus() {
            return this.signStatus;
        }

        public GetSignDetailResponseBodySigners setSignerName(String signerName) {
            this.signerName = signerName;
            return this;
        }
        public String getSignerName() {
            return this.signerName;
        }

    }

}
