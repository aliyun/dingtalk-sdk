// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetFileResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public GetFileResponseBodyData data;

    @NameInMap("message")
    public String message;

    public static GetFileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFileResponseBody self = new GetFileResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFileResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public GetFileResponseBody setData(GetFileResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetFileResponseBodyData getData() {
        return this.data;
    }

    public GetFileResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GetFileResponseBodyData extends TeaModel {
        @NameInMap("downloadUrl")
        public String downloadUrl;

        @NameInMap("fileId")
        public String fileId;

        @NameInMap("name")
        public String name;

        @NameInMap("pdfTotalPages")
        public Integer pdfTotalPages;

        @NameInMap("size")
        public Long size;

        @NameInMap("status")
        public Integer status;

        public static GetFileResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetFileResponseBodyData self = new GetFileResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetFileResponseBodyData setDownloadUrl(String downloadUrl) {
            this.downloadUrl = downloadUrl;
            return this;
        }
        public String getDownloadUrl() {
            return this.downloadUrl;
        }

        public GetFileResponseBodyData setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public GetFileResponseBodyData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetFileResponseBodyData setPdfTotalPages(Integer pdfTotalPages) {
            this.pdfTotalPages = pdfTotalPages;
            return this;
        }
        public Integer getPdfTotalPages() {
            return this.pdfTotalPages;
        }

        public GetFileResponseBodyData setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public GetFileResponseBodyData setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

}
