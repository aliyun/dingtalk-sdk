// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class DeliverCardResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<DeliverCardResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static DeliverCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeliverCardResponseBody self = new DeliverCardResponseBody();
        return TeaModel.build(map, self);
    }

    public DeliverCardResponseBody setResult(java.util.List<DeliverCardResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<DeliverCardResponseBodyResult> getResult() {
        return this.result;
    }

    public DeliverCardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DeliverCardResponseBodyResult extends TeaModel {
        /**
         * <p>场域Id</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        /**
         * <p>场域类型 (IM: IM, IM_SINGLE: IM单聊, IM_GROUP: IM群聊, ONE_BOX: 群吊顶, COOPERATION_FEED: 协作, WORK_BENCH: 工作台)</p>
         */
        @NameInMap("spaceType")
        public String spaceType;

        /**
         * <p>投放成功</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static DeliverCardResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DeliverCardResponseBodyResult self = new DeliverCardResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DeliverCardResponseBodyResult setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public DeliverCardResponseBodyResult setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

        public DeliverCardResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
