// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetFileInfoResponseBody extends TeaModel {
    // 文件内容类型
    @NameInMap("contentType")
    public String contentType;

    // 创建时间
    @NameInMap("createTime")
    public String createTime;

    // 创建者
    @NameInMap("creator")
    public String creator;

    // 文件后缀
    @NameInMap("fileExtension")
    public String fileExtension;

    // 文件id
    @NameInMap("fileId")
    public String fileId;

    // 文件名称
    @NameInMap("fileName")
    public String fileName;

    // 文件路径
    @NameInMap("filePath")
    public String filePath;

    // 文件大小
    @NameInMap("fileSize")
    public Long fileSize;

    // 文件类型
    @NameInMap("fileType")
    public String fileType;

    // 修改者
    @NameInMap("modifier")
    public String modifier;

    // 修改时间
    @NameInMap("modifyTime")
    public String modifyTime;

    // 父目录id
    @NameInMap("parentId")
    public String parentId;

    // 空间id
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
