// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetFileInfoResponseBody extends TeaModel {
    @NameInMap("downloadUrl")
    public String downloadUrl;

    @NameInMap("fileId")
    public String fileId;

    @NameInMap("name")
    public String name;

    @NameInMap("pdfTotalPages")
    public Long pdfTotalPages;

    @NameInMap("size")
    public Long size;

    @NameInMap("status")
    public Long status;

    public static GetFileInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFileInfoResponseBody self = new GetFileInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFileInfoResponseBody setDownloadUrl(String downloadUrl) {
        this.downloadUrl = downloadUrl;
        return this;
    }
    public String getDownloadUrl() {
        return this.downloadUrl;
    }

    public GetFileInfoResponseBody setFileId(String fileId) {
        this.fileId = fileId;
        return this;
    }
    public String getFileId() {
        return this.fileId;
    }

    public GetFileInfoResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetFileInfoResponseBody setPdfTotalPages(Long pdfTotalPages) {
        this.pdfTotalPages = pdfTotalPages;
        return this;
    }
    public Long getPdfTotalPages() {
        return this.pdfTotalPages;
    }

    public GetFileInfoResponseBody setSize(Long size) {
        this.size = size;
        return this;
    }
    public Long getSize() {
        return this.size;
    }

    public GetFileInfoResponseBody setStatus(Long status) {
        this.status = status;
        return this;
    }
    public Long getStatus() {
        return this.status;
    }

}
