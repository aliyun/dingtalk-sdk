// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class ConvertUnionIdResponseBody extends TeaModel {
    @NameInMap("result")
    public ConvertUnionIdResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static ConvertUnionIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ConvertUnionIdResponseBody self = new ConvertUnionIdResponseBody();
        return TeaModel.build(map, self);
    }

    public ConvertUnionIdResponseBody setResult(ConvertUnionIdResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ConvertUnionIdResponseBodyResult getResult() {
        return this.result;
    }

    public ConvertUnionIdResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ConvertUnionIdResponseBodyResultIsvUserUnionIdVOList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>unionId123</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <strong>example:</strong>
         * <p>userId123</p>
         */
        @NameInMap("userId")
        public String userId;

        public static ConvertUnionIdResponseBodyResultIsvUserUnionIdVOList build(java.util.Map<String, ?> map) throws Exception {
            ConvertUnionIdResponseBodyResultIsvUserUnionIdVOList self = new ConvertUnionIdResponseBodyResultIsvUserUnionIdVOList();
            return TeaModel.build(map, self);
        }

        public ConvertUnionIdResponseBodyResultIsvUserUnionIdVOList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public ConvertUnionIdResponseBodyResultIsvUserUnionIdVOList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class ConvertUnionIdResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>corpId123</p>
         */
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("isvUserUnionIdVOList")
        public java.util.List<ConvertUnionIdResponseBodyResultIsvUserUnionIdVOList> isvUserUnionIdVOList;

        public static ConvertUnionIdResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ConvertUnionIdResponseBodyResult self = new ConvertUnionIdResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ConvertUnionIdResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ConvertUnionIdResponseBodyResult setIsvUserUnionIdVOList(java.util.List<ConvertUnionIdResponseBodyResultIsvUserUnionIdVOList> isvUserUnionIdVOList) {
            this.isvUserUnionIdVOList = isvUserUnionIdVOList;
            return this;
        }
        public java.util.List<ConvertUnionIdResponseBodyResultIsvUserUnionIdVOList> getIsvUserUnionIdVOList() {
            return this.isvUserUnionIdVOList;
        }

    }

}
