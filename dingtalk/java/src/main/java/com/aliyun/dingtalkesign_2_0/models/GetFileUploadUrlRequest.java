// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetFileUploadUrlRequest extends TeaModel {
    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("contentMd5")
    public String contentMd5;

    @NameInMap("contentType")
    public String contentType;

    @NameInMap("fileName")
    public String fileName;

    @NameInMap("fileSize")
    public Long fileSize;

    @NameInMap("convert2Pdf")
    public Boolean convert2Pdf;

    public static GetFileUploadUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFileUploadUrlRequest self = new GetFileUploadUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetFileUploadUrlRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public GetFileUploadUrlRequest setContentMd5(String contentMd5) {
        this.contentMd5 = contentMd5;
        return this;
    }
    public String getContentMd5() {
        return this.contentMd5;
    }

    public GetFileUploadUrlRequest setContentType(String contentType) {
        this.contentType = contentType;
        return this;
    }
    public String getContentType() {
        return this.contentType;
    }

    public GetFileUploadUrlRequest setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public GetFileUploadUrlRequest setFileSize(Long fileSize) {
        this.fileSize = fileSize;
        return this;
    }
    public Long getFileSize() {
        return this.fileSize;
    }

    public GetFileUploadUrlRequest setConvert2Pdf(Boolean convert2Pdf) {
        this.convert2Pdf = convert2Pdf;
        return this;
    }
    public Boolean getConvert2Pdf() {
        return this.convert2Pdf;
    }

}
