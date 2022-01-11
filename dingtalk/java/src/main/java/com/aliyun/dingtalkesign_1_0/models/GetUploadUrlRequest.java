// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetUploadUrlRequest extends TeaModel {
    @NameInMap("contentMd5")
    public String contentMd5;

    @NameInMap("contentType")
    public String contentType;

    @NameInMap("convert2Pdf")
    public Boolean convert2Pdf;

    @NameInMap("fileName")
    public String fileName;

    @NameInMap("fileSize")
    public Long fileSize;

    public static GetUploadUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUploadUrlRequest self = new GetUploadUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetUploadUrlRequest setContentMd5(String contentMd5) {
        this.contentMd5 = contentMd5;
        return this;
    }
    public String getContentMd5() {
        return this.contentMd5;
    }

    public GetUploadUrlRequest setContentType(String contentType) {
        this.contentType = contentType;
        return this;
    }
    public String getContentType() {
        return this.contentType;
    }

    public GetUploadUrlRequest setConvert2Pdf(Boolean convert2Pdf) {
        this.convert2Pdf = convert2Pdf;
        return this;
    }
    public Boolean getConvert2Pdf() {
        return this.convert2Pdf;
    }

    public GetUploadUrlRequest setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public GetUploadUrlRequest setFileSize(Long fileSize) {
        this.fileSize = fileSize;
        return this;
    }
    public Long getFileSize() {
        return this.fileSize;
    }

}
