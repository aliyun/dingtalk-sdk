// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateOrganizationTaskResponseBody extends TeaModel {
    // 返回结果对象
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
        // 创建者头像地址
        @NameInMap("avatarUrl")
        public String avatarUrl;

        // 创建者姓名
        @NameInMap("name")
        public String name;

        // 创建者id
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
        // 头像地址
        @NameInMap("avatarUrl")
        public String avatarUrl;

        // 姓名
        @NameInMap("name")
        public String name;

        // 执行者id
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
        // 头像
        @NameInMap("avatarUrl")
        public String avatarUrl;

        // 用户id
        @NameInMap("id")
        public String id;

        // 名字
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
        // 父任务Id
        @NameInMap("ancestorIds")
        public java.util.List<String> ancestorIds;

        // 附件数量
        @NameInMap("attachmentsCount")
        public Integer attachmentsCount;

        // 任务标题
        @NameInMap("content")
        public String content;

        // 创建时间
        @NameInMap("created")
        public String created;

        // 创建者
        @NameInMap("creator")
        public CreateOrganizationTaskResponseBodyResultCreator creator;

        // 创建者id
        @NameInMap("creatorId")
        public String creatorId;

        // 任务截止日期
        @NameInMap("dueDate")
        public String dueDate;

        // 执行者
        @NameInMap("executor")
        public CreateOrganizationTaskResponseBodyResultExecutor executor;

        // 执行者id
        @NameInMap("executorId")
        public String executorId;

        // 是否有提醒
        @NameInMap("hasReminder")
        public Boolean hasReminder;

        // 任务id
        @NameInMap("id")
        public String id;

        // 参与者id列表
        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        // 参与者列表
        @NameInMap("involvers")
        public java.util.List<CreateOrganizationTaskResponseBodyResultInvolvers> involvers;

        // 是否删除
        @NameInMap("isDeleted")
        public Boolean isDeleted;

        // 是否完成
        @NameInMap("isDone")
        public String isDone;

        // 任务自定义标记
        @NameInMap("labels")
        public java.util.List<String> labels;

        // 任务备注
        @NameInMap("note")
        public String note;

        // 优先级【-10,0,1,2】中选一个
        @NameInMap("priority")
        public Integer priority;

        // 标签
        @NameInMap("tagIds")
        public java.util.List<String> tagIds;

        // 更新时间
        @NameInMap("updated")
        public String updated;

        // 任务可见性。involves：仅参与者可见。members:所有人可见
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

        public CreateOrganizationTaskResponseBodyResult setLabels(java.util.List<String> labels) {
            this.labels = labels;
            return this;
        }
        public java.util.List<String> getLabels() {
            return this.labels;
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

        public CreateOrganizationTaskResponseBodyResult setTagIds(java.util.List<String> tagIds) {
            this.tagIds = tagIds;
            return this;
        }
        public java.util.List<String> getTagIds() {
            return this.tagIds;
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
