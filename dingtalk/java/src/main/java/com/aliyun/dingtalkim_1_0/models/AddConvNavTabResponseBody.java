// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddConvNavTabResponseBody extends TeaModel {
    @NameInMap("result")
    public AddConvNavTabResponseBodyResult result;

    @NameInMap("success")
    public String success;

    public static AddConvNavTabResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddConvNavTabResponseBody self = new AddConvNavTabResponseBody();
        return TeaModel.build(map, self);
    }

    public AddConvNavTabResponseBody setResult(AddConvNavTabResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddConvNavTabResponseBodyResult getResult() {
        return this.result;
    }

    public AddConvNavTabResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class AddConvNavTabResponseBodyResult extends TeaModel {
        @NameInMap("tabId")
        public String tabId;

        public static AddConvNavTabResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddConvNavTabResponseBodyResult self = new AddConvNavTabResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddConvNavTabResponseBodyResult setTabId(String tabId) {
            this.tabId = tabId;
            return this;
        }
        public String getTabId() {
            return this.tabId;
        }

    }

}
