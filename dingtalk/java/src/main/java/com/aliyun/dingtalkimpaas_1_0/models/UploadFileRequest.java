// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class UploadFileRequest extends TeaModel {
    @NameInMap("fileName")
    public String fileName;

    @NameInMap("fileType")
    public String fileType;

    @NameInMap("fileUrl")
    public String fileUrl;

    @NameInMap("senderUid")
    public String senderUid;

    public static UploadFileRequest build(java.util.Map<String, ?> map) throws Exception {
        UploadFileRequest self = new UploadFileRequest();
        return TeaModel.build(map, self);
    }

    public UploadFileRequest setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public UploadFileRequest setFileType(String fileType) {
        this.fileType = fileType;
        return this;
    }
    public String getFileType() {
        return this.fileType;
    }

    public UploadFileRequest setFileUrl(String fileUrl) {
        this.fileUrl = fileUrl;
        return this;
    }
    public String getFileUrl() {
        return this.fileUrl;
    }

    public UploadFileRequest setSenderUid(String senderUid) {
        this.senderUid = senderUid;
        return this;
    }
    public String getSenderUid() {
        return this.senderUid;
    }

}
