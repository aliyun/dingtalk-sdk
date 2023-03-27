// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class RedirectWorkflowTaskRequest extends TeaModel {
    /**
     * <p>操作节点名</p>
     */
    @NameInMap("actionName")
    public String actionName;

    /**
     * <p>文件。</p>
     */
    @NameInMap("file")
    public RedirectWorkflowTaskRequestFile file;

    /**
     * <p>操作人的用户ID，需要跟任务的当前执行人保持一致，否则无法通过校验</p>
     */
    @NameInMap("operateUserId")
    public String operateUserId;

    /**
     * <p>转交备注信息</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>OA审批任务ID</p>
     */
    @NameInMap("taskId")
    public Long taskId;

    /**
     * <p>OA审批任务被转交对象的用户ID</p>
     */
    @NameInMap("toUserId")
    public String toUserId;

    public static RedirectWorkflowTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        RedirectWorkflowTaskRequest self = new RedirectWorkflowTaskRequest();
        return TeaModel.build(map, self);
    }

    public RedirectWorkflowTaskRequest setActionName(String actionName) {
        this.actionName = actionName;
        return this;
    }
    public String getActionName() {
        return this.actionName;
    }

    public RedirectWorkflowTaskRequest setFile(RedirectWorkflowTaskRequestFile file) {
        this.file = file;
        return this;
    }
    public RedirectWorkflowTaskRequestFile getFile() {
        return this.file;
    }

    public RedirectWorkflowTaskRequest setOperateUserId(String operateUserId) {
        this.operateUserId = operateUserId;
        return this;
    }
    public String getOperateUserId() {
        return this.operateUserId;
    }

    public RedirectWorkflowTaskRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public RedirectWorkflowTaskRequest setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

    public RedirectWorkflowTaskRequest setToUserId(String toUserId) {
        this.toUserId = toUserId;
        return this;
    }
    public String getToUserId() {
        return this.toUserId;
    }

    public static class RedirectWorkflowTaskRequestFileAttachments extends TeaModel {
        /**
         * <p>文件ID。</p>
         */
        @NameInMap("fileId")
        public String fileId;

        /**
         * <p>文件名称。</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <p>文件大小。</p>
         */
        @NameInMap("fileSize")
        public String fileSize;

        /**
         * <p>文件类型。</p>
         */
        @NameInMap("fileType")
        public String fileType;

        /**
         * <p>钉盘空间ID。</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        public static RedirectWorkflowTaskRequestFileAttachments build(java.util.Map<String, ?> map) throws Exception {
            RedirectWorkflowTaskRequestFileAttachments self = new RedirectWorkflowTaskRequestFileAttachments();
            return TeaModel.build(map, self);
        }

        public RedirectWorkflowTaskRequestFileAttachments setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public RedirectWorkflowTaskRequestFileAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public RedirectWorkflowTaskRequestFileAttachments setFileSize(String fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public String getFileSize() {
            return this.fileSize;
        }

        public RedirectWorkflowTaskRequestFileAttachments setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public RedirectWorkflowTaskRequestFileAttachments setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

    public static class RedirectWorkflowTaskRequestFile extends TeaModel {
        /**
         * <p>附件列表。</p>
         */
        @NameInMap("attachments")
        public java.util.List<RedirectWorkflowTaskRequestFileAttachments> attachments;

        /**
         * <p>图片URL地址。</p>
         */
        @NameInMap("photos")
        public java.util.List<String> photos;

        public static RedirectWorkflowTaskRequestFile build(java.util.Map<String, ?> map) throws Exception {
            RedirectWorkflowTaskRequestFile self = new RedirectWorkflowTaskRequestFile();
            return TeaModel.build(map, self);
        }

        public RedirectWorkflowTaskRequestFile setAttachments(java.util.List<RedirectWorkflowTaskRequestFileAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<RedirectWorkflowTaskRequestFileAttachments> getAttachments() {
            return this.attachments;
        }

        public RedirectWorkflowTaskRequestFile setPhotos(java.util.List<String> photos) {
            this.photos = photos;
            return this;
        }
        public java.util.List<String> getPhotos() {
            return this.photos;
        }

    }

}
