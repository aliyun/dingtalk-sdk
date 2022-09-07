// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class AddProcessInstanceCommentRequest extends TeaModel {
    // 评论人的userid。
    @NameInMap("commentUserId")
    public String commentUserId;

    // 文件。
    @NameInMap("file")
    public AddProcessInstanceCommentRequestFile file;

    // 审批实例ID，可通过调用获取审批实例ID列表接口获取。
    @NameInMap("processInstanceId")
    public String processInstanceId;

    // 评论的内容。
    @NameInMap("text")
    public String text;

    public static AddProcessInstanceCommentRequest build(java.util.Map<String, ?> map) throws Exception {
        AddProcessInstanceCommentRequest self = new AddProcessInstanceCommentRequest();
        return TeaModel.build(map, self);
    }

    public AddProcessInstanceCommentRequest setCommentUserId(String commentUserId) {
        this.commentUserId = commentUserId;
        return this;
    }
    public String getCommentUserId() {
        return this.commentUserId;
    }

    public AddProcessInstanceCommentRequest setFile(AddProcessInstanceCommentRequestFile file) {
        this.file = file;
        return this;
    }
    public AddProcessInstanceCommentRequestFile getFile() {
        return this.file;
    }

    public AddProcessInstanceCommentRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public AddProcessInstanceCommentRequest setText(String text) {
        this.text = text;
        return this;
    }
    public String getText() {
        return this.text;
    }

    public static class AddProcessInstanceCommentRequestFileAttachments extends TeaModel {
        // 文件ID。
        @NameInMap("fileId")
        public String fileId;

        // 文件名称。
        @NameInMap("fileName")
        public String fileName;

        // 文件大小。
        @NameInMap("fileSize")
        public String fileSize;

        // 文件类型。
        @NameInMap("fileType")
        public String fileType;

        // 钉盘空间ID。
        @NameInMap("spaceId")
        public String spaceId;

        public static AddProcessInstanceCommentRequestFileAttachments build(java.util.Map<String, ?> map) throws Exception {
            AddProcessInstanceCommentRequestFileAttachments self = new AddProcessInstanceCommentRequestFileAttachments();
            return TeaModel.build(map, self);
        }

        public AddProcessInstanceCommentRequestFileAttachments setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public AddProcessInstanceCommentRequestFileAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public AddProcessInstanceCommentRequestFileAttachments setFileSize(String fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public String getFileSize() {
            return this.fileSize;
        }

        public AddProcessInstanceCommentRequestFileAttachments setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public AddProcessInstanceCommentRequestFileAttachments setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

    public static class AddProcessInstanceCommentRequestFile extends TeaModel {
        // 附件列表。
        @NameInMap("attachments")
        public java.util.List<AddProcessInstanceCommentRequestFileAttachments> attachments;

        // 图片URL地址。
        @NameInMap("photos")
        public java.util.List<String> photos;

        public static AddProcessInstanceCommentRequestFile build(java.util.Map<String, ?> map) throws Exception {
            AddProcessInstanceCommentRequestFile self = new AddProcessInstanceCommentRequestFile();
            return TeaModel.build(map, self);
        }

        public AddProcessInstanceCommentRequestFile setAttachments(java.util.List<AddProcessInstanceCommentRequestFileAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<AddProcessInstanceCommentRequestFileAttachments> getAttachments() {
            return this.attachments;
        }

        public AddProcessInstanceCommentRequestFile setPhotos(java.util.List<String> photos) {
            this.photos = photos;
            return this;
        }
        public java.util.List<String> getPhotos() {
            return this.photos;
        }

    }

}
