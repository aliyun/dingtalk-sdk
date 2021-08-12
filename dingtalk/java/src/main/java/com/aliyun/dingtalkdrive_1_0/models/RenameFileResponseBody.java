// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class RenameFileResponseBody extends TeaModel {
    // 空间id
    @NameInMap("spaceId")
    public String spaceId;

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

    // 创建时间
    @NameInMap("createTime")
    public String createTime;

    // 修改时间
    @NameInMap("modifyTime")
    public String modifyTime;

    public static RenameFileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RenameFileResponseBody self = new RenameFileResponseBody();
        return TeaModel.build(map, self);
    }

    public RenameFileResponseBody setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public RenameFileResponseBody setFileId(String fileId) {
        this.fileId = fileId;
        return this;
    }
    public String getFileId() {
        return this.fileId;
    }

    public RenameFileResponseBody setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public RenameFileResponseBody setFilePath(String filePath) {
        this.filePath = filePath;
        return this;
    }
    public String getFilePath() {
        return this.filePath;
    }

    public RenameFileResponseBody setFileType(String fileType) {
        this.fileType = fileType;
        return this;
    }
    public String getFileType() {
        return this.fileType;
    }

    public RenameFileResponseBody setContentType(String contentType) {
        this.contentType = contentType;
        return this;
    }
    public String getContentType() {
        return this.contentType;
    }

    public RenameFileResponseBody setFileExtension(String fileExtension) {
        this.fileExtension = fileExtension;
        return this;
    }
    public String getFileExtension() {
        return this.fileExtension;
    }

    public RenameFileResponseBody setCreateTime(String createTime) {
        this.createTime = createTime;
        return this;
    }
    public String getCreateTime() {
        return this.createTime;
    }

    public RenameFileResponseBody setModifyTime(String modifyTime) {
        this.modifyTime = modifyTime;
        return this;
    }
    public String getModifyTime() {
        return this.modifyTime;
    }

}
