// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetUploadInfoRequest extends TeaModel {
    // 文件名
    @NameInMap("fileName")
    public String fileName;

    // 文件大小
    @NameInMap("fileSize")
    public Long fileSize;

    // 文件md5
    @NameInMap("md5")
    public String md5;

    // 文件名称冲突策略
    @NameInMap("addConflictPolicy")
    public String addConflictPolicy;

    // mediaId
    @NameInMap("mediaId")
    public String mediaId;

    public static GetUploadInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUploadInfoRequest self = new GetUploadInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetUploadInfoRequest setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public GetUploadInfoRequest setFileSize(Long fileSize) {
        this.fileSize = fileSize;
        return this;
    }
    public Long getFileSize() {
        return this.fileSize;
    }

    public GetUploadInfoRequest setMd5(String md5) {
        this.md5 = md5;
        return this;
    }
    public String getMd5() {
        return this.md5;
    }

    public GetUploadInfoRequest setAddConflictPolicy(String addConflictPolicy) {
        this.addConflictPolicy = addConflictPolicy;
        return this;
    }
    public String getAddConflictPolicy() {
        return this.addConflictPolicy;
    }

    public GetUploadInfoRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

}
