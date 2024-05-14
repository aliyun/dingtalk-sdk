// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ExecuteProcessInstanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("actionerUserId")
    public String actionerUserId;

    @NameInMap("file")
    public ExecuteProcessInstanceRequestFile file;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public String result;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskId")
    public Long taskId;

    public static ExecuteProcessInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        ExecuteProcessInstanceRequest self = new ExecuteProcessInstanceRequest();
        return TeaModel.build(map, self);
    }

    public ExecuteProcessInstanceRequest setActionerUserId(String actionerUserId) {
        this.actionerUserId = actionerUserId;
        return this;
    }
    public String getActionerUserId() {
        return this.actionerUserId;
    }

    public ExecuteProcessInstanceRequest setFile(ExecuteProcessInstanceRequestFile file) {
        this.file = file;
        return this;
    }
    public ExecuteProcessInstanceRequestFile getFile() {
        return this.file;
    }

    public ExecuteProcessInstanceRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public ExecuteProcessInstanceRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public ExecuteProcessInstanceRequest setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public ExecuteProcessInstanceRequest setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

    public static class ExecuteProcessInstanceRequestFileAttachments extends TeaModel {
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public String fileSize;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("spaceId")
        public String spaceId;

        public static ExecuteProcessInstanceRequestFileAttachments build(java.util.Map<String, ?> map) throws Exception {
            ExecuteProcessInstanceRequestFileAttachments self = new ExecuteProcessInstanceRequestFileAttachments();
            return TeaModel.build(map, self);
        }

        public ExecuteProcessInstanceRequestFileAttachments setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public ExecuteProcessInstanceRequestFileAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public ExecuteProcessInstanceRequestFileAttachments setFileSize(String fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public String getFileSize() {
            return this.fileSize;
        }

        public ExecuteProcessInstanceRequestFileAttachments setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public ExecuteProcessInstanceRequestFileAttachments setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

    public static class ExecuteProcessInstanceRequestFile extends TeaModel {
        @NameInMap("attachments")
        public java.util.List<ExecuteProcessInstanceRequestFileAttachments> attachments;

        @NameInMap("photos")
        public java.util.List<String> photos;

        public static ExecuteProcessInstanceRequestFile build(java.util.Map<String, ?> map) throws Exception {
            ExecuteProcessInstanceRequestFile self = new ExecuteProcessInstanceRequestFile();
            return TeaModel.build(map, self);
        }

        public ExecuteProcessInstanceRequestFile setAttachments(java.util.List<ExecuteProcessInstanceRequestFileAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<ExecuteProcessInstanceRequestFileAttachments> getAttachments() {
            return this.attachments;
        }

        public ExecuteProcessInstanceRequestFile setPhotos(java.util.List<String> photos) {
            this.photos = photos;
            return this;
        }
        public java.util.List<String> getPhotos() {
            return this.photos;
        }

    }

}
