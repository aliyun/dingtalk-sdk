// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class GetDefineResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetDefineResponseBodyResult> result;

    @NameInMap("totalCount")
    public Long totalCount;

    public static GetDefineResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDefineResponseBody self = new GetDefineResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDefineResponseBody setResult(java.util.List<GetDefineResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetDefineResponseBodyResult> getResult() {
        return this.result;
    }

    public GetDefineResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class GetDefineResponseBodyResult extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        public static GetDefineResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetDefineResponseBodyResult self = new GetDefineResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetDefineResponseBodyResult setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetDefineResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
