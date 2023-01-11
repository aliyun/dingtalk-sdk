// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateOrganizationTaskResponseBody extends TeaModel {
    /**
     * <p>返回结果对象</p>
     */
    @NameInMap("result")
    public CreateOrganizationTaskResponseBodyResult result;

    public static CreateOrganizationTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateOrganizationTaskResponseBody self = new CreateOrganizationTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateOrganizationTaskResponseBody setResult(CreateOrganizationTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateOrganizationTaskResponseBodyResult getResult() {
        return this.result;
    }

    public static class CreateOrganizationTaskResponseBodyResultCreator extends TeaModel {
        /**
         * <p>创建者头像地址</p>
         */
        @NameInMap("avatarUrl")
        public String avatarUrl;

        /**
         * <p>创建者姓名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>创建者id</p>
         */
        @NameInMap("userId")
        public String userId;

        public static CreateOrganizationTaskResponseBodyResultCreator build(java.util.Map<String, ?> map) throws Exception {
            CreateOrganizationTaskResponseBodyResultCreator self = new CreateOrganizationTaskResponseBodyResultCreator();
            return TeaModel.build(map, self);
        }

        public CreateOrganizationTaskResponseBodyResultCreator setAvatarUrl(String avatarUrl) {
            this.avatarUrl = avatarUrl;
            return this;
        }
        public String getAvatarUrl() {
            return this.avatarUrl;
        }

        public CreateOrganizationTaskResponseBodyResultCreator setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateOrganizationTaskResponseBodyResultCreator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class CreateOrganizationTaskResponseBodyResultExecutor extends TeaModel {
        /**
         * <p>头像地址</p>
         */
        @NameInMap("avatarUrl")
        public String avatarUrl;

        /**
         * <p>姓名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>执行者id</p>
         */
        @NameInMap("userId")
        public String userId;

        public static CreateOrganizationTaskResponseBodyResultExecutor build(java.util.Map<String, ?> map) throws Exception {
            CreateOrganizationTaskResponseBodyResultExecutor self = new CreateOrganizationTaskResponseBodyResultExecutor();
            return TeaModel.build(map, self);
        }

        public CreateOrganizationTaskResponseBodyResultExecutor setAvatarUrl(String avatarUrl) {
            this.avatarUrl = avatarUrl;
            return this;
        }
        public String getAvatarUrl() {
            return this.avatarUrl;
        }

        public CreateOrganizationTaskResponseBodyResultExecutor setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateOrganizationTaskResponseBodyResultExecutor setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class CreateOrganizationTaskResponseBodyResultInvolvers extends TeaModel {
        /**
         * <p>头像</p>
         */
        @NameInMap("avatarUrl")
        public String avatarUrl;

        /**
         * <p>用户id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>名字</p>
         */
        @NameInMap("name")
        public String name;

        public static CreateOrganizationTaskResponseBodyResultInvolvers build(java.util.Map<String, ?> map) throws Exception {
            CreateOrganizationTaskResponseBodyResultInvolvers self = new CreateOrganizationTaskResponseBodyResultInvolvers();
            return TeaModel.build(map, self);
        }

        public CreateOrganizationTaskResponseBodyResultInvolvers setAvatarUrl(String avatarUrl) {
            this.avatarUrl = avatarUrl;
            return this;
        }
        public String getAvatarUrl() {
            return this.avatarUrl;
        }

        public CreateOrganizationTaskResponseBodyResultInvolvers setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateOrganizationTaskResponseBodyResultInvolvers setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class CreateOrganizationTaskResponseBodyResult extends TeaModel {
        /**
         * <p>父任务Id</p>
         */
        @NameInMap("ancestorIds")
        public java.util.List<String> ancestorIds;

        /**
         * <p>附件数量</p>
         */
        @NameInMap("attachmentsCount")
        public Integer attachmentsCount;

        /**
         * <p>任务标题</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <p>创建者</p>
         */
        @NameInMap("creator")
        public CreateOrganizationTaskResponseBodyResultCreator creator;

        /**
         * <p>创建者id</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <p>任务截止日期</p>
         */
        @NameInMap("dueDate")
        public String dueDate;

        /**
         * <p>执行者</p>
         */
        @NameInMap("executor")
        public CreateOrganizationTaskResponseBodyResultExecutor executor;

        /**
         * <p>执行者id</p>
         */
        @NameInMap("executorId")
        public String executorId;

        /**
         * <p>是否有提醒</p>
         */
        @NameInMap("hasReminder")
        public Boolean hasReminder;

        /**
         * <p>任务id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>参与者id列表</p>
         */
        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        /**
         * <p>参与者列表</p>
         */
        @NameInMap("involvers")
        public java.util.List<CreateOrganizationTaskResponseBodyResultInvolvers> involvers;

        /**
         * <p>是否删除</p>
         */
        @NameInMap("isDeleted")
        public Boolean isDeleted;

        /**
         * <p>是否完成</p>
         */
        @NameInMap("isDone")
        public String isDone;

        /**
         * <p>任务备注</p>
         */
        @NameInMap("note")
        public String note;

        /**
         * <p>优先级【-10,0,1,2】中选一个</p>
         */
        @NameInMap("priority")
        public Integer priority;

        /**
         * <p>更新时间</p>
         */
        @NameInMap("updated")
        public String updated;

        /**
         * <p>任务可见性。involves：仅参与者可见。members:所有人可见</p>
         */
        @NameInMap("visible")
        public String visible;

        public static CreateOrganizationTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateOrganizationTaskResponseBodyResult self = new CreateOrganizationTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateOrganizationTaskResponseBodyResult setAncestorIds(java.util.List<String> ancestorIds) {
            this.ancestorIds = ancestorIds;
            return this;
        }
        public java.util.List<String> getAncestorIds() {
            return this.ancestorIds;
        }

        public CreateOrganizationTaskResponseBodyResult setAttachmentsCount(Integer attachmentsCount) {
            this.attachmentsCount = attachmentsCount;
            return this;
        }
        public Integer getAttachmentsCount() {
            return this.attachmentsCount;
        }

        public CreateOrganizationTaskResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public CreateOrganizationTaskResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public CreateOrganizationTaskResponseBodyResult setCreator(CreateOrganizationTaskResponseBodyResultCreator creator) {
            this.creator = creator;
            return this;
        }
        public CreateOrganizationTaskResponseBodyResultCreator getCreator() {
            return this.creator;
        }

        public CreateOrganizationTaskResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public CreateOrganizationTaskResponseBodyResult setDueDate(String dueDate) {
            this.dueDate = dueDate;
            return this;
        }
        public String getDueDate() {
            return this.dueDate;
        }

        public CreateOrganizationTaskResponseBodyResult setExecutor(CreateOrganizationTaskResponseBodyResultExecutor executor) {
            this.executor = executor;
            return this;
        }
        public CreateOrganizationTaskResponseBodyResultExecutor getExecutor() {
            return this.executor;
        }

        public CreateOrganizationTaskResponseBodyResult setExecutorId(String executorId) {
            this.executorId = executorId;
            return this;
        }
        public String getExecutorId() {
            return this.executorId;
        }

        public CreateOrganizationTaskResponseBodyResult setHasReminder(Boolean hasReminder) {
            this.hasReminder = hasReminder;
            return this;
        }
        public Boolean getHasReminder() {
            return this.hasReminder;
        }

        public CreateOrganizationTaskResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateOrganizationTaskResponseBodyResult setInvolveMembers(java.util.List<String> involveMembers) {
            this.involveMembers = involveMembers;
            return this;
        }
        public java.util.List<String> getInvolveMembers() {
            return this.involveMembers;
        }

        public CreateOrganizationTaskResponseBodyResult setInvolvers(java.util.List<CreateOrganizationTaskResponseBodyResultInvolvers> involvers) {
            this.involvers = involvers;
            return this;
        }
        public java.util.List<CreateOrganizationTaskResponseBodyResultInvolvers> getInvolvers() {
            return this.involvers;
        }

        public CreateOrganizationTaskResponseBodyResult setIsDeleted(Boolean isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Boolean getIsDeleted() {
            return this.isDeleted;
        }

        public CreateOrganizationTaskResponseBodyResult setIsDone(String isDone) {
            this.isDone = isDone;
            return this;
        }
        public String getIsDone() {
            return this.isDone;
        }

        public CreateOrganizationTaskResponseBodyResult setNote(String note) {
            this.note = note;
            return this;
        }
        public String getNote() {
            return this.note;
        }

        public CreateOrganizationTaskResponseBodyResult setPriority(Integer priority) {
            this.priority = priority;
            return this;
        }
        public Integer getPriority() {
            return this.priority;
        }

        public CreateOrganizationTaskResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

        public CreateOrganizationTaskResponseBodyResult setVisible(String visible) {
            this.visible = visible;
            return this;
        }
        public String getVisible() {
            return this.visible;
        }

    }

}
