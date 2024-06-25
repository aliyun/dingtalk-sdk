// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetFileInfoResponseBody extends TeaModel {
    @NameInMap("contentType")
    public String contentType;

    /**
     * <p>This parameter is required.</p>
     * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
     */
    @NameInMap("createTime")
    public String createTime;

    @NameInMap("creator")
    public String creator;

    @NameInMap("fileExtension")
    public String fileExtension;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fileId")
    public String fileId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fileName")
    public String fileName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("filePath")
    public String filePath;

    @NameInMap("fileSize")
    public Long fileSize;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fileType")
    public String fileType;

    @NameInMap("modifier")
    public String modifier;

    /**
     * <p>This parameter is required.</p>
     * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
     */
    @NameInMap("modifyTime")
    public String modifyTime;

    @NameInMap("parentId")
    public String parentId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("spaceId")
    public String spaceId;

    public static GetFileInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFileInfoResponseBody self = new GetFileInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFileInfoResponseBody setContentType(String contentType) {
        this.contentType = contentType;
        return this;
    }
    public String getContentType() {
        return this.contentType;
    }

    public GetFileInfoResponseBody setCreateTime(String createTime) {
        this.createTime = createTime;
        return this;
    }
    public String getCreateTime() {
        return this.createTime;
    }

    public GetFileInfoResponseBody setCreator(String creator) {
        this.creator = creator;
        return this;
    }
    public String getCreator() {
        return this.creator;
    }

    public GetFileInfoResponseBody setFileExtension(String fileExtension) {
        this.fileExtension = fileExtension;
        return this;
    }
    public String getFileExtension() {
        return this.fileExtension;
    }

    public GetFileInfoResponseBody setFileId(String fileId) {
        this.fileId = fileId;
        return this;
    }
    public String getFileId() {
        return this.fileId;
    }

    public GetFileInfoResponseBody setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public GetFileInfoResponseBody setFilePath(String filePath) {
        this.filePath = filePath;
        return this;
    }
    public String getFilePath() {
        return this.filePath;
    }

    public GetFileInfoResponseBody setFileSize(Long fileSize) {
        this.fileSize = fileSize;
        return this;
    }
    public Long getFileSize() {
        return this.fileSize;
    }

    public GetFileInfoResponseBody setFileType(String fileType) {
        this.fileType = fileType;
        return this;
    }
    public String getFileType() {
        return this.fileType;
    }

    public GetFileInfoResponseBody setModifier(String modifier) {
        this.modifier = modifier;
        return this;
    }
    public String getModifier() {
        return this.modifier;
    }

    public GetFileInfoResponseBody setModifyTime(String modifyTime) {
        this.modifyTime = modifyTime;
        return this;
    }
    public String getModifyTime() {
        return this.modifyTime;
    }

    public GetFileInfoResponseBody setParentId(String parentId) {
        this.parentId = parentId;
        return this;
    }
    public String getParentId() {
        return this.parentId;
    }

    public GetFileInfoResponseBody setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

}
