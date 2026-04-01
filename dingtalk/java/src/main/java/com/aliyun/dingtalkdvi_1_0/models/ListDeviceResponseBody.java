// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ListDeviceResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<ListDeviceResponseBodyResult> result;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static ListDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListDeviceResponseBody self = new ListDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public ListDeviceResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListDeviceResponseBody setResult(java.util.List<ListDeviceResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListDeviceResponseBodyResult> getResult() {
        return this.result;
    }

    public ListDeviceResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class ListDeviceResponseBodyResult extends TeaModel {
        @NameInMap("bindTimestamp")
        public Long bindTimestamp;

        @NameInMap("sn")
        public String sn;

        @NameInMap("teamCode")
        public String teamCode;

        @NameInMap("userId")
        public String userId;

        public static ListDeviceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListDeviceResponseBodyResult self = new ListDeviceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListDeviceResponseBodyResult setBindTimestamp(Long bindTimestamp) {
            this.bindTimestamp = bindTimestamp;
            return this;
        }
        public Long getBindTimestamp() {
            return this.bindTimestamp;
        }

        public ListDeviceResponseBodyResult setSn(String sn) {
            this.sn = sn;
            return this;
        }
        public String getSn() {
            return this.sn;
        }

        public ListDeviceResponseBodyResult setTeamCode(String teamCode) {
            this.teamCode = teamCode;
            return this;
        }
        public String getTeamCode() {
            return this.teamCode;
        }

        public ListDeviceResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
