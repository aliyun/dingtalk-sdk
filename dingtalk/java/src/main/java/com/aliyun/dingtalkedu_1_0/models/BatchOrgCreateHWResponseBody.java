// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class BatchOrgCreateHWResponseBody extends TeaModel {
    @NameInMap("result")
    public BatchOrgCreateHWResponseBodyResult result;

    public static BatchOrgCreateHWResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchOrgCreateHWResponseBody self = new BatchOrgCreateHWResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchOrgCreateHWResponseBody setResult(BatchOrgCreateHWResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public BatchOrgCreateHWResponseBodyResult getResult() {
        return this.result;
    }

    public static class BatchOrgCreateHWResponseBodyResultPublishList extends TeaModel {
        @NameInMap("corpid")
        public String corpid;

        @NameInMap("hwid")
        public Float hwid;

        public static BatchOrgCreateHWResponseBodyResultPublishList build(java.util.Map<String, ?> map) throws Exception {
            BatchOrgCreateHWResponseBodyResultPublishList self = new BatchOrgCreateHWResponseBodyResultPublishList();
            return TeaModel.build(map, self);
        }

        public BatchOrgCreateHWResponseBodyResultPublishList setCorpid(String corpid) {
            this.corpid = corpid;
            return this;
        }
        public String getCorpid() {
            return this.corpid;
        }

        public BatchOrgCreateHWResponseBodyResultPublishList setHwid(Float hwid) {
            this.hwid = hwid;
            return this;
        }
        public Float getHwid() {
            return this.hwid;
        }

    }

    public static class BatchOrgCreateHWResponseBodyResult extends TeaModel {
        @NameInMap("publishList")
        public java.util.List<BatchOrgCreateHWResponseBodyResultPublishList> publishList;

        public static BatchOrgCreateHWResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            BatchOrgCreateHWResponseBodyResult self = new BatchOrgCreateHWResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public BatchOrgCreateHWResponseBodyResult setPublishList(java.util.List<BatchOrgCreateHWResponseBodyResultPublishList> publishList) {
            this.publishList = publishList;
            return this;
        }
        public java.util.List<BatchOrgCreateHWResponseBodyResultPublishList> getPublishList() {
            return this.publishList;
        }

    }

}
