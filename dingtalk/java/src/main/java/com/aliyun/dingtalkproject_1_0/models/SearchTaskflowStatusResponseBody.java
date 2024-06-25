// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchTaskflowStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<SearchTaskflowStatusResponseBodyResult> result;

    public static SearchTaskflowStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchTaskflowStatusResponseBody self = new SearchTaskflowStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchTaskflowStatusResponseBody setResult(java.util.List<SearchTaskflowStatusResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<SearchTaskflowStatusResponseBodyResult> getResult() {
        return this.result;
    }

    public static class SearchTaskflowStatusResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <strong>example:</strong>
         * <p>601fdeb17f86xxxxxxxx</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("isDeleted")
        public Boolean isDeleted;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("isTaskflowstatusruleexector")
        public Boolean isTaskflowstatusruleexector;

        /**
         * <strong>example:</strong>
         * <p>start</p>
         */
        @NameInMap("kind")
        public String kind;

        /**
         * <strong>example:</strong>
         * <p>未开始</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("pos")
        public Integer pos;

        @NameInMap("rejectStatusIds")
        public java.util.List<String> rejectStatusIds;

        /**
         * <strong>example:</strong>
         * <p>60a2187eb72xxxxxxx</p>
         */
        @NameInMap("taskflowId")
        public String taskflowId;

        /**
         * <strong>example:</strong>
         * <p>60a2187eb72xxxxxxx</p>
         */
        @NameInMap("taskflowStatusId")
        public String taskflowStatusId;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        public static SearchTaskflowStatusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SearchTaskflowStatusResponseBodyResult self = new SearchTaskflowStatusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SearchTaskflowStatusResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public SearchTaskflowStatusResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public SearchTaskflowStatusResponseBodyResult setIsDeleted(Boolean isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Boolean getIsDeleted() {
            return this.isDeleted;
        }

        public SearchTaskflowStatusResponseBodyResult setIsTaskflowstatusruleexector(Boolean isTaskflowstatusruleexector) {
            this.isTaskflowstatusruleexector = isTaskflowstatusruleexector;
            return this;
        }
        public Boolean getIsTaskflowstatusruleexector() {
            return this.isTaskflowstatusruleexector;
        }

        public SearchTaskflowStatusResponseBodyResult setKind(String kind) {
            this.kind = kind;
            return this;
        }
        public String getKind() {
            return this.kind;
        }

        public SearchTaskflowStatusResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchTaskflowStatusResponseBodyResult setPos(Integer pos) {
            this.pos = pos;
            return this;
        }
        public Integer getPos() {
            return this.pos;
        }

        public SearchTaskflowStatusResponseBodyResult setRejectStatusIds(java.util.List<String> rejectStatusIds) {
            this.rejectStatusIds = rejectStatusIds;
            return this;
        }
        public java.util.List<String> getRejectStatusIds() {
            return this.rejectStatusIds;
        }

        public SearchTaskflowStatusResponseBodyResult setTaskflowId(String taskflowId) {
            this.taskflowId = taskflowId;
            return this;
        }
        public String getTaskflowId() {
            return this.taskflowId;
        }

        public SearchTaskflowStatusResponseBodyResult setTaskflowStatusId(String taskflowStatusId) {
            this.taskflowStatusId = taskflowStatusId;
            return this;
        }
        public String getTaskflowStatusId() {
            return this.taskflowStatusId;
        }

        public SearchTaskflowStatusResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
