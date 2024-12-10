// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocSlotsModifyResponseBody extends TeaModel {
    @NameInMap("result")
    public DocSlotsModifyResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static DocSlotsModifyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DocSlotsModifyResponseBody self = new DocSlotsModifyResponseBody();
        return TeaModel.build(map, self);
    }

    public DocSlotsModifyResponseBody setResult(DocSlotsModifyResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DocSlotsModifyResponseBodyResult getResult() {
        return this.result;
    }

    public DocSlotsModifyResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DocSlotsModifyResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public java.util.Map<String, String> data;

        public static DocSlotsModifyResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DocSlotsModifyResponseBodyResult self = new DocSlotsModifyResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DocSlotsModifyResponseBodyResult setData(java.util.Map<String, String> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, String> getData() {
            return this.data;
        }

    }

}
