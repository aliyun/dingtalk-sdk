// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class SyncDataResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<SyncDataResponseBodyList> list;

    public static SyncDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncDataResponseBody self = new SyncDataResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncDataResponseBody setList(java.util.List<SyncDataResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<SyncDataResponseBodyList> getList() {
        return this.list;
    }

    public static class SyncDataResponseBodyList extends TeaModel {
        @NameInMap("bizPrimaryKey")
        public String bizPrimaryKey;

        @NameInMap("subErrCode")
        public String subErrCode;

        @NameInMap("subErrMsg")
        public String subErrMsg;

        @NameInMap("success")
        public Boolean success;

        @NameInMap("triggerId")
        public String triggerId;

        public static SyncDataResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            SyncDataResponseBodyList self = new SyncDataResponseBodyList();
            return TeaModel.build(map, self);
        }

        public SyncDataResponseBodyList setBizPrimaryKey(String bizPrimaryKey) {
            this.bizPrimaryKey = bizPrimaryKey;
            return this;
        }
        public String getBizPrimaryKey() {
            return this.bizPrimaryKey;
        }

        public SyncDataResponseBodyList setSubErrCode(String subErrCode) {
            this.subErrCode = subErrCode;
            return this;
        }
        public String getSubErrCode() {
            return this.subErrCode;
        }

        public SyncDataResponseBodyList setSubErrMsg(String subErrMsg) {
            this.subErrMsg = subErrMsg;
            return this;
        }
        public String getSubErrMsg() {
            return this.subErrMsg;
        }

        public SyncDataResponseBodyList setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

        public SyncDataResponseBodyList setTriggerId(String triggerId) {
            this.triggerId = triggerId;
            return this;
        }
        public String getTriggerId() {
            return this.triggerId;
        }

    }

}
