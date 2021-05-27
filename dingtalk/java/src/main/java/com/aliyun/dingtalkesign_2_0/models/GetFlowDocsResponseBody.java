// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetFlowDocsResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<GetFlowDocsResponseBodyData> data;

    public static GetFlowDocsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFlowDocsResponseBody self = new GetFlowDocsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFlowDocsResponseBody setData(java.util.List<GetFlowDocsResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetFlowDocsResponseBodyData> getData() {
        return this.data;
    }

    public static class GetFlowDocsResponseBodyData extends TeaModel {
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileUrl")
        public String fileUrl;

        public static GetFlowDocsResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetFlowDocsResponseBodyData self = new GetFlowDocsResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetFlowDocsResponseBodyData setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public GetFlowDocsResponseBodyData setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public GetFlowDocsResponseBodyData setFileUrl(String fileUrl) {
            this.fileUrl = fileUrl;
            return this;
        }
        public String getFileUrl() {
            return this.fileUrl;
        }

    }

}
