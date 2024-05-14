// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesTeamMgmtResponseBody extends TeaModel {
    @NameInMap("dingOpenErrcode")
    public Integer dingOpenErrcode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("errorMsg")
    public String errorMsg;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public IndustryManufactureMesTeamMgmtResponseBodyResult result;

    public static IndustryManufactureMesTeamMgmtResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesTeamMgmtResponseBody self = new IndustryManufactureMesTeamMgmtResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesTeamMgmtResponseBody setDingOpenErrcode(Integer dingOpenErrcode) {
        this.dingOpenErrcode = dingOpenErrcode;
        return this;
    }
    public Integer getDingOpenErrcode() {
        return this.dingOpenErrcode;
    }

    public IndustryManufactureMesTeamMgmtResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public IndustryManufactureMesTeamMgmtResponseBody setResult(IndustryManufactureMesTeamMgmtResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public IndustryManufactureMesTeamMgmtResponseBodyResult getResult() {
        return this.result;
    }

    public static class IndustryManufactureMesTeamMgmtResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("content")
        public String content;

        public static IndustryManufactureMesTeamMgmtResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesTeamMgmtResponseBodyResult self = new IndustryManufactureMesTeamMgmtResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesTeamMgmtResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

    }

}
