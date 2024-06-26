// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class ListObjectiveByUserResponseBody extends TeaModel {
    @NameInMap("content")
    public ListObjectiveByUserResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static ListObjectiveByUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListObjectiveByUserResponseBody self = new ListObjectiveByUserResponseBody();
        return TeaModel.build(map, self);
    }

    public ListObjectiveByUserResponseBody setContent(ListObjectiveByUserResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public ListObjectiveByUserResponseBodyContent getContent() {
        return this.content;
    }

    public ListObjectiveByUserResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public ListObjectiveByUserResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ListObjectiveByUserResponseBodyContent extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("count")
        public Integer count;

        @NameInMap("objectives")
        public java.util.List<OpenObjectiveDTO> objectives;

        public static ListObjectiveByUserResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            ListObjectiveByUserResponseBodyContent self = new ListObjectiveByUserResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public ListObjectiveByUserResponseBodyContent setCount(Integer count) {
            this.count = count;
            return this;
        }
        public Integer getCount() {
            return this.count;
        }

        public ListObjectiveByUserResponseBodyContent setObjectives(java.util.List<OpenObjectiveDTO> objectives) {
            this.objectives = objectives;
            return this;
        }
        public java.util.List<OpenObjectiveDTO> getObjectives() {
            return this.objectives;
        }

    }

}
