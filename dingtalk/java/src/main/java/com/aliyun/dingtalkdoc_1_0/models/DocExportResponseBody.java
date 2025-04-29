// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocExportResponseBody extends TeaModel {
    @NameInMap("result")
    public DocExportResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static DocExportResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DocExportResponseBody self = new DocExportResponseBody();
        return TeaModel.build(map, self);
    }

    public DocExportResponseBody setResult(DocExportResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DocExportResponseBodyResult getResult() {
        return this.result;
    }

    public DocExportResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DocExportResponseBodyResult extends TeaModel {
        @NameInMap("taskId")
        public Long taskId;

        public static DocExportResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DocExportResponseBodyResult self = new DocExportResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DocExportResponseBodyResult setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

    }

}
