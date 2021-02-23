// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class BatchOrgCreateHWResponseBody extends TeaModel {
    @NameInMap("errormsg")
    public String errormsg;

    @NameInMap("dingopenerrcode")
    public Integer dingopenerrcode;

    @NameInMap("success")
    public Boolean success;

    @NameInMap("result")
    public BatchOrgCreateHWResponseBodyResult result;

    public static BatchOrgCreateHWResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchOrgCreateHWResponseBody self = new BatchOrgCreateHWResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchOrgCreateHWResponseBody setErrormsg(String errormsg) {
        this.errormsg = errormsg;
        return this;
    }
    public String getErrormsg() {
        return this.errormsg;
    }

    public BatchOrgCreateHWResponseBody setDingopenerrcode(Integer dingopenerrcode) {
        this.dingopenerrcode = dingopenerrcode;
        return this;
    }
    public Integer getDingopenerrcode() {
        return this.dingopenerrcode;
    }

    public BatchOrgCreateHWResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public BatchOrgCreateHWResponseBody setResult(BatchOrgCreateHWResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public BatchOrgCreateHWResponseBodyResult getResult() {
        return this.result;
    }

    public static class BatchOrgCreateHWResponseBodyResultHwpublishresultdtolist extends TeaModel {
        @NameInMap("corpid")
        public String corpid;

        @NameInMap("hwid")
        public Float hwid;

        public static BatchOrgCreateHWResponseBodyResultHwpublishresultdtolist build(java.util.Map<String, ?> map) throws Exception {
            BatchOrgCreateHWResponseBodyResultHwpublishresultdtolist self = new BatchOrgCreateHWResponseBodyResultHwpublishresultdtolist();
            return TeaModel.build(map, self);
        }

        public BatchOrgCreateHWResponseBodyResultHwpublishresultdtolist setCorpid(String corpid) {
            this.corpid = corpid;
            return this;
        }
        public String getCorpid() {
            return this.corpid;
        }

        public BatchOrgCreateHWResponseBodyResultHwpublishresultdtolist setHwid(Float hwid) {
            this.hwid = hwid;
            return this;
        }
        public Float getHwid() {
            return this.hwid;
        }

    }

    public static class BatchOrgCreateHWResponseBodyResult extends TeaModel {
        @NameInMap("hwpublishresultdtolist")
        public java.util.List<BatchOrgCreateHWResponseBodyResultHwpublishresultdtolist> hwpublishresultdtolist;

        public static BatchOrgCreateHWResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            BatchOrgCreateHWResponseBodyResult self = new BatchOrgCreateHWResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public BatchOrgCreateHWResponseBodyResult setHwpublishresultdtolist(java.util.List<BatchOrgCreateHWResponseBodyResultHwpublishresultdtolist> hwpublishresultdtolist) {
            this.hwpublishresultdtolist = hwpublishresultdtolist;
            return this;
        }
        public java.util.List<BatchOrgCreateHWResponseBodyResultHwpublishresultdtolist> getHwpublishresultdtolist() {
            return this.hwpublishresultdtolist;
        }

    }

}
