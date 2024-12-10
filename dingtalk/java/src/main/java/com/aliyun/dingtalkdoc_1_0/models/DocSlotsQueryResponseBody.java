// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocSlotsQueryResponseBody extends TeaModel {
    @NameInMap("result")
    public DocSlotsQueryResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static DocSlotsQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DocSlotsQueryResponseBody self = new DocSlotsQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public DocSlotsQueryResponseBody setResult(DocSlotsQueryResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DocSlotsQueryResponseBodyResult getResult() {
        return this.result;
    }

    public DocSlotsQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DocSlotsQueryResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public java.util.List<?> data;

        public static DocSlotsQueryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DocSlotsQueryResponseBodyResult self = new DocSlotsQueryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DocSlotsQueryResponseBodyResult setData(java.util.List<?> data) {
            this.data = data;
            return this;
        }
        public java.util.List<?> getData() {
            return this.data;
        }

    }

}
