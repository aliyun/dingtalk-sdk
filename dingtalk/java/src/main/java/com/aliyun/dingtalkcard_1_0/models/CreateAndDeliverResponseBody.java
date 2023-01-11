// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CreateAndDeliverResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateAndDeliverResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateAndDeliverResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateAndDeliverResponseBody self = new CreateAndDeliverResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateAndDeliverResponseBody setResult(CreateAndDeliverResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateAndDeliverResponseBodyResult getResult() {
        return this.result;
    }

    public CreateAndDeliverResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateAndDeliverResponseBodyResultDeliverResults extends TeaModel {
        /**
         * <p>错误信息</p>
         */
        @NameInMap("errorMsg")
        public String errorMsg;

        /**
         * <p>场域Id</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        /**
         * <p>场域类型 (IM: IM类型，包括群聊和单聊，仅供返回结果使用, IM_SINGLE: IM单聊, IM_GROUP: IM群聊, ONE_BOX: 群吊顶, COOPERATION_FEED: 协作, WORK_BENCH: 工作台)</p>
         */
        @NameInMap("spaceType")
        public String spaceType;

        /**
         * <p>投放成功</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static CreateAndDeliverResponseBodyResultDeliverResults build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverResponseBodyResultDeliverResults self = new CreateAndDeliverResponseBodyResultDeliverResults();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverResponseBodyResultDeliverResults setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public CreateAndDeliverResponseBodyResultDeliverResults setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public CreateAndDeliverResponseBodyResultDeliverResults setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

        public CreateAndDeliverResponseBodyResultDeliverResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

    public static class CreateAndDeliverResponseBodyResult extends TeaModel {
        /**
         * <p>投放结果</p>
         */
        @NameInMap("deliverResults")
        public java.util.List<CreateAndDeliverResponseBodyResultDeliverResults> deliverResults;

        /**
         * <p>外部卡片实例Id</p>
         */
        @NameInMap("outTrackId")
        public String outTrackId;

        public static CreateAndDeliverResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverResponseBodyResult self = new CreateAndDeliverResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverResponseBodyResult setDeliverResults(java.util.List<CreateAndDeliverResponseBodyResultDeliverResults> deliverResults) {
            this.deliverResults = deliverResults;
            return this;
        }
        public java.util.List<CreateAndDeliverResponseBodyResultDeliverResults> getDeliverResults() {
            return this.deliverResults;
        }

        public CreateAndDeliverResponseBodyResult setOutTrackId(String outTrackId) {
            this.outTrackId = outTrackId;
            return this;
        }
        public String getOutTrackId() {
            return this.outTrackId;
        }

    }

}
