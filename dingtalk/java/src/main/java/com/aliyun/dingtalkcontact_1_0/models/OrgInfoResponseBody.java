// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class OrgInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<OrgInfoResponseBodyResult> result;

    public static OrgInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OrgInfoResponseBody self = new OrgInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public OrgInfoResponseBody setResult(java.util.List<OrgInfoResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<OrgInfoResponseBodyResult> getResult() {
        return this.result;
    }

    public static class OrgInfoResponseBodyResult extends TeaModel {
        @NameInMap("id")
        public Long id;

        @NameInMap("name")
        public String name;

        public static OrgInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            OrgInfoResponseBodyResult self = new OrgInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public OrgInfoResponseBodyResult setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public OrgInfoResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
