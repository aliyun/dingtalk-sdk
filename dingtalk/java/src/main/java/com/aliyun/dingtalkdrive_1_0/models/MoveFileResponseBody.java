// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class MoveFileResponseBody extends TeaModel {
    // 空间id
    @NameInMap("spaceId")
    public String spaceId;

    // 父目录id
    @NameInMap("parentId")
    public String parentId;

    // 文件id
    @NameInMap("fileId")
    public String fileId;

    // 文件名称
    @NameInMap("fileName")
    public String fileName;

    // 文件路径
    @NameInMap("filePath")
    public String filePath;

    // 文件类型
    @NameInMap("fileType")
    public String fileType;

    // 文件内容类型
    @NameInMap("contentType")
    public String contentType;

    // 文件后缀
    @NameInMap("fileExtension")
    public String fileExtension;

    // 文件大小
    @NameInMap("fileSize")
    public Long fileSize;

    // 创建时间
    @NameInMap("createTime")
    public String createTime;

    // 修改时间
    @NameInMap("modifyTime")
    public String modifyTime;

    // 创建者
    @NameInMap("creator")
    public String creator;

    // 修改者
    @NameInMap("modifier")
    public String modifier;

    public static MoveFileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        MoveFileResponseBody self = new MoveFileResponseBody();
        return TeaModel.build(map, self);
    }

    public MoveFileResponseBody setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public MoveFileResponseBody setParentId(String parentId) {
        this.parentId = parentId;
        return this;
    }
    public String getParentId() {
        return this.parentId;
    }

    public MoveFileResponseBody setFileId(String fileId) {
        this.fileId = fileId;
        return this;
    }
    public String getFileId() {
        return this.fileId;
    }

    public MoveFileResponseBody setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public MoveFileResponseBody setFilePath(String filePath) {
        this.filePath = filePath;
        return this;
    }
    public String getFilePath() {
        return this.filePath;
    }

    public MoveFileResponseBody setFileType(String fileType) {
        this.fileType = fileType;
        return this;
    }
    public String getFileType() {
        return this.fileType;
    }

    public MoveFileResponseBody setContentType(String contentType) {
        this.contentType = contentType;
        return this;
    }
    public String getContentType() {
        return this.contentType;
    }

    public MoveFileResponseBody setFileExtension(String fileExtension) {
        this.fileExtension = fileExtension;
        return this;
    }
    public String getFileExtension() {
        return this.fileExtension;
    }

    public MoveFileResponseBody setFileSize(Long fileSize) {
        this.fileSize = fileSize;
        return this;
    }
    public Long getFileSize() {
        return this.fileSize;
    }

    public MoveFileResponseBody setCreateTime(String createTime) {
        this.createTime = createTime;
        return this;
    }
    public String getCreateTime() {
        return this.createTime;
    }

    public MoveFileResponseBody setModifyTime(String modifyTime) {
        this.modifyTime = modifyTime;
        return this;
    }
    public String getModifyTime() {
        return this.modifyTime;
    }

    public MoveFileResponseBody setCreator(String creator) {
        this.creator = creator;
        return this;
    }
    public String getCreator() {
        return this.creator;
    }

    public MoveFileResponseBody setModifier(String modifier) {
        this.modifier = modifier;
        return this;
    }
    public String getModifier() {
        return this.modifier;
    }

}
