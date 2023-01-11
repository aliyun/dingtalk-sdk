// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class GetMiniAppMetaDataResponseBody extends TeaModel {
    /**
     * <p>receiveTime</p>
     */
    @NameInMap("dingOpenErrcode")
    public Long dingOpenErrcode;

    /**
     * <p>errorMsg</p>
     */
    @NameInMap("errorMsg")
    public String errorMsg;

    /**
     * <p>result</p>
     */
    @NameInMap("result")
    public GetMiniAppMetaDataResponseBodyResult result;

    /**
     * <p>requestId</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static GetMiniAppMetaDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMiniAppMetaDataResponseBody self = new GetMiniAppMetaDataResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMiniAppMetaDataResponseBody setDingOpenErrcode(Long dingOpenErrcode) {
        this.dingOpenErrcode = dingOpenErrcode;
        return this;
    }
    public Long getDingOpenErrcode() {
        return this.dingOpenErrcode;
    }

    public GetMiniAppMetaDataResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public GetMiniAppMetaDataResponseBody setResult(GetMiniAppMetaDataResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetMiniAppMetaDataResponseBodyResult getResult() {
        return this.result;
    }

    public GetMiniAppMetaDataResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetMiniAppMetaDataResponseBodyResult extends TeaModel {
        /**
         * <p>data</p>
         */
        @NameInMap("data")
        public java.util.Map<String, ?> data;

        public static GetMiniAppMetaDataResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetMiniAppMetaDataResponseBodyResult self = new GetMiniAppMetaDataResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetMiniAppMetaDataResponseBodyResult setData(java.util.Map<String, ?> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, ?> getData() {
            return this.data;
        }

    }

}
