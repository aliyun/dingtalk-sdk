// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchTaskflowStatusResponseBody extends TeaModel {
    /**
     * <p>工作流状态列表。</p>
     */
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
         * <p>创建时间。</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <p>创建者ID。</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <p>工作流状态ID。</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>是否已删除。</p>
         */
        @NameInMap("isDeleted")
        public Boolean isDeleted;

        /**
         * <p>是否特定任务角色才能流转该工作流状态。</p>
         */
        @NameInMap("isTaskflowstatusruleexector")
        public Boolean isTaskflowstatusruleexector;

        /**
         * <p>start,end,unset</p>
         */
        @NameInMap("kind")
        public String kind;

        /**
         * <p>工作流状态名字。</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>工作流状态位置。</p>
         */
        @NameInMap("pos")
        public Integer pos;

        /**
         * <p>该工作流状态不能流转到其他工作流状态。</p>
         */
        @NameInMap("rejectStatusIds")
        public java.util.List<String> rejectStatusIds;

        /**
         * <p>工作流状态ID。</p>
         */
        @NameInMap("taskflowId")
        public String taskflowId;

        /**
         * <p>更新时间。</p>
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

        public SearchTaskflowStatusResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
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

        public SearchTaskflowStatusResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
