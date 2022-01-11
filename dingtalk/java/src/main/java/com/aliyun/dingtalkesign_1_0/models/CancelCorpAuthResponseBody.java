// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class CancelCorpAuthResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public CancelCorpAuthResponseBodyData data;

    @NameInMap("message")
    public String message;

    public static CancelCorpAuthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CancelCorpAuthResponseBody self = new CancelCorpAuthResponseBody();
        return TeaModel.build(map, self);
    }

    public CancelCorpAuthResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public CancelCorpAuthResponseBody setData(CancelCorpAuthResponseBodyData data) {
        this.data = data;
        return this;
    }
    public CancelCorpAuthResponseBodyData getData() {
        return this.data;
    }

    public CancelCorpAuthResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class CancelCorpAuthResponseBodyData extends TeaModel {
        @NameInMap("result")
        public Boolean result;

        public static CancelCorpAuthResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            CancelCorpAuthResponseBodyData self = new CancelCorpAuthResponseBodyData();
            return TeaModel.build(map, self);
        }

        public CancelCorpAuthResponseBodyData setResult(Boolean result) {
            this.result = result;
            return this;
        }
        public Boolean getResult() {
            return this.result;
        }

    }

}
