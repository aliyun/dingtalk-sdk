// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ListClueTagResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<ListClueTagResponseBodyResult> result;

    public static ListClueTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListClueTagResponseBody self = new ListClueTagResponseBody();
        return TeaModel.build(map, self);
    }

    public ListClueTagResponseBody setResult(java.util.List<ListClueTagResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListClueTagResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ListClueTagResponseBodyResult extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("tagId")
        public String tagId;

        public static ListClueTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListClueTagResponseBodyResult self = new ListClueTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListClueTagResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListClueTagResponseBodyResult setTagId(String tagId) {
            this.tagId = tagId;
            return this;
        }
        public String getTagId() {
            return this.tagId;
        }

    }

}
