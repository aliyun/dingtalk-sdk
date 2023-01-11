// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateObjectiveResponseBody extends TeaModel {
    /**
     * <p>data</p>
     */
    @NameInMap("data")
    public UpdateObjectiveResponseBodyData data;

    /**
     * <p>请求成功的标识。</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static UpdateObjectiveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateObjectiveResponseBody self = new UpdateObjectiveResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateObjectiveResponseBody setData(UpdateObjectiveResponseBodyData data) {
        this.data = data;
        return this;
    }
    public UpdateObjectiveResponseBodyData getData() {
        return this.data;
    }

    public UpdateObjectiveResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class UpdateObjectiveResponseBodyData extends TeaModel {
        /**
         * <p>当前 Objective ID。</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>当前 Objective 的位置。</p>
         */
        @NameInMap("position")
        public Float position;

        public static UpdateObjectiveResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            UpdateObjectiveResponseBodyData self = new UpdateObjectiveResponseBodyData();
            return TeaModel.build(map, self);
        }

        public UpdateObjectiveResponseBodyData setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public UpdateObjectiveResponseBodyData setPosition(Float position) {
            this.position = position;
            return this;
        }
        public Float getPosition() {
            return this.position;
        }

    }

}
