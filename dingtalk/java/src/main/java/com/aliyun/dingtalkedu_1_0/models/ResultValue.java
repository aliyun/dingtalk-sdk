// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ResultValue extends TeaModel {
    @NameInMap("thumbnail")
    public String thumbnail;

    @NameInMap("fileSize")
    public Long fileSize;

    @NameInMap("extension")
    public String extension;

    @NameInMap("fileName")
    public String fileName;

    @NameInMap("url")
    public String url;

    public static ResultValue build(java.util.Map<String, ?> map) throws Exception {
        ResultValue self = new ResultValue();
        return TeaModel.build(map, self);
    }

    public ResultValue setThumbnail(String thumbnail) {
        this.thumbnail = thumbnail;
        return this;
    }
    public String getThumbnail() {
        return this.thumbnail;
    }

    public ResultValue setFileSize(Long fileSize) {
        this.fileSize = fileSize;
        return this;
    }
    public Long getFileSize() {
        return this.fileSize;
    }

    public ResultValue setExtension(String extension) {
        this.extension = extension;
        return this;
    }
    public String getExtension() {
        return this.extension;
    }

    public ResultValue setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public ResultValue setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
