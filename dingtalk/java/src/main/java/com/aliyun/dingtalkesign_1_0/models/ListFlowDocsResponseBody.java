// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class ListFlowDocsResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public java.util.List<ListFlowDocsResponseBodyData> data;

    @NameInMap("message")
    public String message;

    public static ListFlowDocsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListFlowDocsResponseBody self = new ListFlowDocsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListFlowDocsResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public ListFlowDocsResponseBody setData(java.util.List<ListFlowDocsResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<ListFlowDocsResponseBodyData> getData() {
        return this.data;
    }

    public ListFlowDocsResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class ListFlowDocsResponseBodyData extends TeaModel {
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileUrl")
        public String fileUrl;

        public static ListFlowDocsResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            ListFlowDocsResponseBodyData self = new ListFlowDocsResponseBodyData();
            return TeaModel.build(map, self);
        }

        public ListFlowDocsResponseBodyData setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public ListFlowDocsResponseBodyData setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public ListFlowDocsResponseBodyData setFileUrl(String fileUrl) {
            this.fileUrl = fileUrl;
            return this;
        }
        public String getFileUrl() {
            return this.fileUrl;
        }

    }

}
