// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetDismissionRecordResponseBody extends TeaModel {
    @NameInMap("result")
    public GetDismissionRecordResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetDismissionRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDismissionRecordResponseBody self = new GetDismissionRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDismissionRecordResponseBody setResult(GetDismissionRecordResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetDismissionRecordResponseBodyResult getResult() {
        return this.result;
    }

    public GetDismissionRecordResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetDismissionRecordResponseBodyResultList extends TeaModel {
        @NameInMap("lastWorkDay")
        public Long lastWorkDay;

        @NameInMap("staffId")
        public String staffId;

        public static GetDismissionRecordResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            GetDismissionRecordResponseBodyResultList self = new GetDismissionRecordResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public GetDismissionRecordResponseBodyResultList setLastWorkDay(Long lastWorkDay) {
            this.lastWorkDay = lastWorkDay;
            return this;
        }
        public Long getLastWorkDay() {
            return this.lastWorkDay;
        }

        public GetDismissionRecordResponseBodyResultList setStaffId(String staffId) {
            this.staffId = staffId;
            return this;
        }
        public String getStaffId() {
            return this.staffId;
        }

    }

    public static class GetDismissionRecordResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public GetDismissionRecordResponseBodyResultList list;

        @NameInMap("nextCursor")
        public Long nextCursor;

        public static GetDismissionRecordResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetDismissionRecordResponseBodyResult self = new GetDismissionRecordResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetDismissionRecordResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public GetDismissionRecordResponseBodyResult setList(GetDismissionRecordResponseBodyResultList list) {
            this.list = list;
            return this;
        }
        public GetDismissionRecordResponseBodyResultList getList() {
            return this.list;
        }

        public GetDismissionRecordResponseBodyResult setNextCursor(Long nextCursor) {
            this.nextCursor = nextCursor;
            return this;
        }
        public Long getNextCursor() {
            return this.nextCursor;
        }

    }

}
