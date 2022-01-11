// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetAttachsApprovalResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("data")
    public java.util.List<GetAttachsApprovalResponseBodyData> data;

    public static GetAttachsApprovalResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAttachsApprovalResponseBody self = new GetAttachsApprovalResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAttachsApprovalResponseBody setData(java.util.List<GetAttachsApprovalResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetAttachsApprovalResponseBodyData> getData() {
        return this.data;
    }

    public static class GetAttachsApprovalResponseBodyDataFiles extends TeaModel {
        @NameInMap("fileName")
        public String fileName;

        @NameInMap("originalFileUrl")
        public String originalFileUrl;

        @NameInMap("signFinishFileUrl")
        public String signFinishFileUrl;

        public static GetAttachsApprovalResponseBodyDataFiles build(java.util.Map<String, ?> map) throws Exception {
            GetAttachsApprovalResponseBodyDataFiles self = new GetAttachsApprovalResponseBodyDataFiles();
            return TeaModel.build(map, self);
        }

        public GetAttachsApprovalResponseBodyDataFiles setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public GetAttachsApprovalResponseBodyDataFiles setOriginalFileUrl(String originalFileUrl) {
            this.originalFileUrl = originalFileUrl;
            return this;
        }
        public String getOriginalFileUrl() {
            return this.originalFileUrl;
        }

        public GetAttachsApprovalResponseBodyDataFiles setSignFinishFileUrl(String signFinishFileUrl) {
            this.signFinishFileUrl = signFinishFileUrl;
            return this;
        }
        public String getSignFinishFileUrl() {
            return this.signFinishFileUrl;
        }

    }

    public static class GetAttachsApprovalResponseBodyData extends TeaModel {
        @NameInMap("files")
        public java.util.List<GetAttachsApprovalResponseBodyDataFiles> files;

        @NameInMap("flowId")
        public String flowId;

        @NameInMap("status")
        public String status;

        public static GetAttachsApprovalResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetAttachsApprovalResponseBodyData self = new GetAttachsApprovalResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetAttachsApprovalResponseBodyData setFiles(java.util.List<GetAttachsApprovalResponseBodyDataFiles> files) {
            this.files = files;
            return this;
        }
        public java.util.List<GetAttachsApprovalResponseBodyDataFiles> getFiles() {
            return this.files;
        }

        public GetAttachsApprovalResponseBodyData setFlowId(String flowId) {
            this.flowId = flowId;
            return this;
        }
        public String getFlowId() {
            return this.flowId;
        }

        public GetAttachsApprovalResponseBodyData setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
