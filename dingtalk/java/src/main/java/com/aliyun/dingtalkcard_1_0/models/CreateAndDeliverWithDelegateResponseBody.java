// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CreateAndDeliverWithDelegateResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateAndDeliverWithDelegateResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateAndDeliverWithDelegateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateAndDeliverWithDelegateResponseBody self = new CreateAndDeliverWithDelegateResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateAndDeliverWithDelegateResponseBody setResult(CreateAndDeliverWithDelegateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateAndDeliverWithDelegateResponseBodyResult getResult() {
        return this.result;
    }

    public CreateAndDeliverWithDelegateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateAndDeliverWithDelegateResponseBodyResultDeliverResults extends TeaModel {
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

        public static CreateAndDeliverWithDelegateResponseBodyResultDeliverResults build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateResponseBodyResultDeliverResults self = new CreateAndDeliverWithDelegateResponseBodyResultDeliverResults();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateResponseBodyResultDeliverResults setCarrierId(String carrierId) {
            this.carrierId = carrierId;
            return this;
        }
        public String getCarrierId() {
            return this.carrierId;
        }

        public CreateAndDeliverWithDelegateResponseBodyResultDeliverResults setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public CreateAndDeliverWithDelegateResponseBodyResultDeliverResults setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public CreateAndDeliverWithDelegateResponseBodyResultDeliverResults setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

        public CreateAndDeliverWithDelegateResponseBodyResultDeliverResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

    public static class CreateAndDeliverWithDelegateResponseBodyResult extends TeaModel {
        @NameInMap("deliverResults")
        public java.util.List<CreateAndDeliverWithDelegateResponseBodyResultDeliverResults> deliverResults;

        @NameInMap("outTrackId")
        public String outTrackId;

        public static CreateAndDeliverWithDelegateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateResponseBodyResult self = new CreateAndDeliverWithDelegateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateResponseBodyResult setDeliverResults(java.util.List<CreateAndDeliverWithDelegateResponseBodyResultDeliverResults> deliverResults) {
            this.deliverResults = deliverResults;
            return this;
        }
        public java.util.List<CreateAndDeliverWithDelegateResponseBodyResultDeliverResults> getDeliverResults() {
            return this.deliverResults;
        }

        public CreateAndDeliverWithDelegateResponseBodyResult setOutTrackId(String outTrackId) {
            this.outTrackId = outTrackId;
            return this;
        }
        public String getOutTrackId() {
            return this.outTrackId;
        }

    }

}
