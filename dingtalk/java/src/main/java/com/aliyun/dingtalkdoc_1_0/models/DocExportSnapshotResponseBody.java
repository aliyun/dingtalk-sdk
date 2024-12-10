// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocExportSnapshotResponseBody extends TeaModel {
    @NameInMap("result")
    public DocExportSnapshotResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static DocExportSnapshotResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DocExportSnapshotResponseBody self = new DocExportSnapshotResponseBody();
        return TeaModel.build(map, self);
    }

    public DocExportSnapshotResponseBody setResult(DocExportSnapshotResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DocExportSnapshotResponseBodyResult getResult() {
        return this.result;
    }

    public DocExportSnapshotResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DocExportSnapshotResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public java.util.Map<String, String> data;

        public static DocExportSnapshotResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DocExportSnapshotResponseBodyResult self = new DocExportSnapshotResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DocExportSnapshotResponseBodyResult setData(java.util.Map<String, String> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, String> getData() {
            return this.data;
        }

    }

}
