// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateOrganizationTaskResponseBody extends TeaModel {
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
        @NameInMap("avatarUrl")
        public String avatarUrl;

        @NameInMap("name")
        public String name;

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
        @NameInMap("avatarUrl")
        public String avatarUrl;

        @NameInMap("name")
        public String name;

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
        @NameInMap("avatarUrl")
        public String avatarUrl;

        @NameInMap("id")
        public String id;

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
        @NameInMap("ancestorIds")
        public java.util.List<String> ancestorIds;

        @NameInMap("attachmentsCount")
        public Integer attachmentsCount;

        @NameInMap("content")
        public String content;

        @NameInMap("created")
        public String created;

        @NameInMap("creator")
        public CreateOrganizationTaskResponseBodyResultCreator creator;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("dueDate")
        public String dueDate;

        @NameInMap("executor")
        public CreateOrganizationTaskResponseBodyResultExecutor executor;

        @NameInMap("executorId")
        public String executorId;

        @NameInMap("hasReminder")
        public Boolean hasReminder;

        @NameInMap("id")
        public String id;

        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        @NameInMap("involvers")
        public java.util.List<CreateOrganizationTaskResponseBodyResultInvolvers> involvers;

        @NameInMap("isDeleted")
        public Boolean isDeleted;

        @NameInMap("isDone")
        public String isDone;

        @NameInMap("note")
        public String note;

        @NameInMap("priority")
        public Integer priority;

        @NameInMap("updated")
        public String updated;

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
