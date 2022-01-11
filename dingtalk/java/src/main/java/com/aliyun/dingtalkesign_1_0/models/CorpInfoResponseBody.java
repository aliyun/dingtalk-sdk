// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class CorpInfoResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public CorpInfoResponseBodyData data;

    @NameInMap("message")
    public String message;

    public static CorpInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CorpInfoResponseBody self = new CorpInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public CorpInfoResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public CorpInfoResponseBody setData(CorpInfoResponseBodyData data) {
        this.data = data;
        return this;
    }
    public CorpInfoResponseBodyData getData() {
        return this.data;
    }

    public CorpInfoResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class CorpInfoResponseBodyData extends TeaModel {
        @NameInMap("orgRealName")
        public String orgRealName;

        @NameInMap("realName")
        public Boolean realName;

        public static CorpInfoResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            CorpInfoResponseBodyData self = new CorpInfoResponseBodyData();
            return TeaModel.build(map, self);
        }

        public CorpInfoResponseBodyData setOrgRealName(String orgRealName) {
            this.orgRealName = orgRealName;
            return this;
        }
        public String getOrgRealName() {
            return this.orgRealName;
        }

        public CorpInfoResponseBodyData setRealName(Boolean realName) {
            this.realName = realName;
            return this;
        }
        public Boolean getRealName() {
            return this.realName;
        }

    }

}
