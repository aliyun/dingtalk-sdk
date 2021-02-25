// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class CorpConsoleResponseBody extends TeaModel {
    @NameInMap("data")
    public CorpConsoleResponseBodyData data;

    @NameInMap("code")
    public Integer code;

    @NameInMap("message")
    public String message;

    public static CorpConsoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CorpConsoleResponseBody self = new CorpConsoleResponseBody();
        return TeaModel.build(map, self);
    }

    public CorpConsoleResponseBody setData(CorpConsoleResponseBodyData data) {
        this.data = data;
        return this;
    }
    public CorpConsoleResponseBodyData getData() {
        return this.data;
    }

    public CorpConsoleResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public CorpConsoleResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class CorpConsoleResponseBodyData extends TeaModel {
        @NameInMap("orgConsoleUrl")
        public Long orgConsoleUrl;

        public static CorpConsoleResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            CorpConsoleResponseBodyData self = new CorpConsoleResponseBodyData();
            return TeaModel.build(map, self);
        }

        public CorpConsoleResponseBodyData setOrgConsoleUrl(Long orgConsoleUrl) {
            this.orgConsoleUrl = orgConsoleUrl;
            return this;
        }
        public Long getOrgConsoleUrl() {
            return this.orgConsoleUrl;
        }

    }

}
