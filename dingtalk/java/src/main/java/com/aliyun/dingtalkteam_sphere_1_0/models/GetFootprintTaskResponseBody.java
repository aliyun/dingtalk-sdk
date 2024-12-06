// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetFootprintTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetFootprintTaskResponseBodyResult> result;

    public static GetFootprintTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFootprintTaskResponseBody self = new GetFootprintTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFootprintTaskResponseBody setResult(java.util.List<GetFootprintTaskResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetFootprintTaskResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetFootprintTaskResponseBodyResultCustomfields extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>666a472803e46df8ce98a4a5</p>
         */
        @NameInMap("customfieldId")
        public String customfieldId;

        /**
         * <strong>example:</strong>
         * <p>date</p>
         */
        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public java.util.List<java.util.Map<String, ?>> value;

        @NameInMap("values")
        public java.util.List<String> values;

        public static GetFootprintTaskResponseBodyResultCustomfields build(java.util.Map<String, ?> map) throws Exception {
            GetFootprintTaskResponseBodyResultCustomfields self = new GetFootprintTaskResponseBodyResultCustomfields();
            return TeaModel.build(map, self);
        }

        public GetFootprintTaskResponseBodyResultCustomfields setCustomfieldId(String customfieldId) {
            this.customfieldId = customfieldId;
            return this;
        }
        public String getCustomfieldId() {
            return this.customfieldId;
        }

        public GetFootprintTaskResponseBodyResultCustomfields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetFootprintTaskResponseBodyResultCustomfields setValue(java.util.List<java.util.Map<String, ?>> value) {
            this.value = value;
            return this;
        }
        public java.util.List<java.util.Map<String, ?>> getValue() {
            return this.value;
        }

        public GetFootprintTaskResponseBodyResultCustomfields setValues(java.util.List<String> values) {
            this.values = values;
            return this;
        }
        public java.util.List<String> getValues() {
            return this.values;
        }

    }

    public static class GetFootprintTaskResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2024-09-19T11:07:51.468Z</p>
         */
        @NameInMap("accomplished")
        public String accomplished;

        @NameInMap("basicPos")
        public String basicPos;

        @NameInMap("content")
        public String content;

        @NameInMap("created")
        public String created;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("customfields")
        public java.util.List<GetFootprintTaskResponseBodyResultCustomfields> customfields;

        /**
         * <strong>example:</strong>
         * <p>2024-09-13T10:00:00.000Z</p>
         */
        @NameInMap("dueDate")
        public String dueDate;

        @NameInMap("executorId")
        public String executorId;

        @NameInMap("id")
        public String id;

        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("isArchived")
        public Boolean isArchived;

        @NameInMap("isDeleted")
        public Boolean isDeleted;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("isDone")
        public Boolean isDone;

        /**
         * <strong>example:</strong>
         * <p>test123</p>
         */
        @NameInMap("note")
        public String note;

        @NameInMap("organizationId")
        public String organizationId;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("pos")
        public Long pos;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("priority")
        public Long priority;

        @NameInMap("projectId")
        public String projectId;

        @NameInMap("sfcId")
        public String sfcId;

        /**
         * <strong>example:</strong>
         * <p>6639f974916cdb178e7d***</p>
         */
        @NameInMap("stageId")
        public String stageId;

        /**
         * <strong>example:</strong>
         * <p>2024-09-13T10:00:00.000Z</p>
         */
        @NameInMap("startDate")
        public String startDate;

        /**
         * <strong>example:</strong>
         * <p>6639f974916cdb178e7d***</p>
         */
        @NameInMap("tasklistId")
        public String tasklistId;

        /**
         * <strong>example:</strong>
         * <p>6639f974916cdb178e7****</p>
         */
        @NameInMap("tfsId")
        public String tfsId;

        /**
         * <strong>example:</strong>
         * <p>540</p>
         */
        @NameInMap("uniqueId")
        public Long uniqueId;

        @NameInMap("updated")
        public String updated;

        /**
         * <strong>example:</strong>
         * <p>members</p>
         */
        @NameInMap("visible")
        public String visible;

        public static GetFootprintTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetFootprintTaskResponseBodyResult self = new GetFootprintTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetFootprintTaskResponseBodyResult setAccomplished(String accomplished) {
            this.accomplished = accomplished;
            return this;
        }
        public String getAccomplished() {
            return this.accomplished;
        }

        public GetFootprintTaskResponseBodyResult setBasicPos(String basicPos) {
            this.basicPos = basicPos;
            return this;
        }
        public String getBasicPos() {
            return this.basicPos;
        }

        public GetFootprintTaskResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetFootprintTaskResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public GetFootprintTaskResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetFootprintTaskResponseBodyResult setCustomfields(java.util.List<GetFootprintTaskResponseBodyResultCustomfields> customfields) {
            this.customfields = customfields;
            return this;
        }
        public java.util.List<GetFootprintTaskResponseBodyResultCustomfields> getCustomfields() {
            return this.customfields;
        }

        public GetFootprintTaskResponseBodyResult setDueDate(String dueDate) {
            this.dueDate = dueDate;
            return this;
        }
        public String getDueDate() {
            return this.dueDate;
        }

        public GetFootprintTaskResponseBodyResult setExecutorId(String executorId) {
            this.executorId = executorId;
            return this;
        }
        public String getExecutorId() {
            return this.executorId;
        }

        public GetFootprintTaskResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetFootprintTaskResponseBodyResult setInvolveMembers(java.util.List<String> involveMembers) {
            this.involveMembers = involveMembers;
            return this;
        }
        public java.util.List<String> getInvolveMembers() {
            return this.involveMembers;
        }

        public GetFootprintTaskResponseBodyResult setIsArchived(Boolean isArchived) {
            this.isArchived = isArchived;
            return this;
        }
        public Boolean getIsArchived() {
            return this.isArchived;
        }

        public GetFootprintTaskResponseBodyResult setIsDeleted(Boolean isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Boolean getIsDeleted() {
            return this.isDeleted;
        }

        public GetFootprintTaskResponseBodyResult setIsDone(Boolean isDone) {
            this.isDone = isDone;
            return this;
        }
        public Boolean getIsDone() {
            return this.isDone;
        }

        public GetFootprintTaskResponseBodyResult setNote(String note) {
            this.note = note;
            return this;
        }
        public String getNote() {
            return this.note;
        }

        public GetFootprintTaskResponseBodyResult setOrganizationId(String organizationId) {
            this.organizationId = organizationId;
            return this;
        }
        public String getOrganizationId() {
            return this.organizationId;
        }

        public GetFootprintTaskResponseBodyResult setPos(Long pos) {
            this.pos = pos;
            return this;
        }
        public Long getPos() {
            return this.pos;
        }

        public GetFootprintTaskResponseBodyResult setPriority(Long priority) {
            this.priority = priority;
            return this;
        }
        public Long getPriority() {
            return this.priority;
        }

        public GetFootprintTaskResponseBodyResult setProjectId(String projectId) {
            this.projectId = projectId;
            return this;
        }
        public String getProjectId() {
            return this.projectId;
        }

        public GetFootprintTaskResponseBodyResult setSfcId(String sfcId) {
            this.sfcId = sfcId;
            return this;
        }
        public String getSfcId() {
            return this.sfcId;
        }

        public GetFootprintTaskResponseBodyResult setStageId(String stageId) {
            this.stageId = stageId;
            return this;
        }
        public String getStageId() {
            return this.stageId;
        }

        public GetFootprintTaskResponseBodyResult setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public GetFootprintTaskResponseBodyResult setTasklistId(String tasklistId) {
            this.tasklistId = tasklistId;
            return this;
        }
        public String getTasklistId() {
            return this.tasklistId;
        }

        public GetFootprintTaskResponseBodyResult setTfsId(String tfsId) {
            this.tfsId = tfsId;
            return this;
        }
        public String getTfsId() {
            return this.tfsId;
        }

        public GetFootprintTaskResponseBodyResult setUniqueId(Long uniqueId) {
            this.uniqueId = uniqueId;
            return this;
        }
        public Long getUniqueId() {
            return this.uniqueId;
        }

        public GetFootprintTaskResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

        public GetFootprintTaskResponseBodyResult setVisible(String visible) {
            this.visible = visible;
            return this;
        }
        public String getVisible() {
            return this.visible;
        }

    }

}
