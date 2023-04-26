// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetFileUploadInfoRequest extends TeaModel {
    @NameInMap("bizCode")
    public String bizCode;

    @NameInMap("fileName")
    public String fileName;

    @NameInMap("fileSize")
    public Long fileSize;

    @NameInMap("md5")
    public String md5;

    @NameInMap("opUserId")
    public String opUserId;

    public static GetFileUploadInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFileUploadInfoRequest self = new GetFileUploadInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetFileUploadInfoRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public GetFileUploadInfoRequest setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public GetFileUploadInfoRequest setFileSize(Long fileSize) {
        this.fileSize = fileSize;
        return this;
    }
    public Long getFileSize() {
        return this.fileSize;
    }

    public GetFileUploadInfoRequest setMd5(String md5) {
        this.md5 = md5;
        return this;
    }
    public String getMd5() {
        return this.md5;
    }

    public GetFileUploadInfoRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
