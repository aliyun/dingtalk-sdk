// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ImportCandidateByResumeRequest extends TeaModel {
    @NameInMap("channelCode")
    public String channelCode;

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
    @NameInMap("fileSize")
    public Long fileSize;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fileSourceType")
    public Integer fileSourceType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fileType")
    public String fileType;

    @NameInMap("spaceId")
    public Long spaceId;

    @NameInMap("url")
    public String url;

    @NameInMap("opUserId")
    public String opUserId;

    public static ImportCandidateByResumeRequest build(java.util.Map<String, ?> map) throws Exception {
        ImportCandidateByResumeRequest self = new ImportCandidateByResumeRequest();
        return TeaModel.build(map, self);
    }

    public ImportCandidateByResumeRequest setChannelCode(String channelCode) {
        this.channelCode = channelCode;
        return this;
    }
    public String getChannelCode() {
        return this.channelCode;
    }

    public ImportCandidateByResumeRequest setFileId(String fileId) {
        this.fileId = fileId;
        return this;
    }
    public String getFileId() {
        return this.fileId;
    }

    public ImportCandidateByResumeRequest setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public ImportCandidateByResumeRequest setFileSize(Long fileSize) {
        this.fileSize = fileSize;
        return this;
    }
    public Long getFileSize() {
        return this.fileSize;
    }

    public ImportCandidateByResumeRequest setFileSourceType(Integer fileSourceType) {
        this.fileSourceType = fileSourceType;
        return this;
    }
    public Integer getFileSourceType() {
        return this.fileSourceType;
    }

    public ImportCandidateByResumeRequest setFileType(String fileType) {
        this.fileType = fileType;
        return this;
    }
    public String getFileType() {
        return this.fileType;
    }

    public ImportCandidateByResumeRequest setSpaceId(Long spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public Long getSpaceId() {
        return this.spaceId;
    }

    public ImportCandidateByResumeRequest setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

    public ImportCandidateByResumeRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
