// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentQueryTagLikeDetailListResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentQueryTagLikeDetailListResponseBodyResult result;

    public static TalentQueryTagLikeDetailListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentQueryTagLikeDetailListResponseBody self = new TalentQueryTagLikeDetailListResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentQueryTagLikeDetailListResponseBody setResult(TalentQueryTagLikeDetailListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentQueryTagLikeDetailListResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentQueryTagLikeDetailListResponseBodyResultLikeDetails extends TeaModel {
        @NameInMap("likeTimestamp")
        public Long likeTimestamp;

        @NameInMap("operatorUserId")
        public String operatorUserId;

        public static TalentQueryTagLikeDetailListResponseBodyResultLikeDetails build(java.util.Map<String, ?> map) throws Exception {
            TalentQueryTagLikeDetailListResponseBodyResultLikeDetails self = new TalentQueryTagLikeDetailListResponseBodyResultLikeDetails();
            return TeaModel.build(map, self);
        }

        public TalentQueryTagLikeDetailListResponseBodyResultLikeDetails setLikeTimestamp(Long likeTimestamp) {
            this.likeTimestamp = likeTimestamp;
            return this;
        }
        public Long getLikeTimestamp() {
            return this.likeTimestamp;
        }

        public TalentQueryTagLikeDetailListResponseBodyResultLikeDetails setOperatorUserId(String operatorUserId) {
            this.operatorUserId = operatorUserId;
            return this;
        }
        public String getOperatorUserId() {
            return this.operatorUserId;
        }

    }

    public static class TalentQueryTagLikeDetailListResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("likeDetails")
        public java.util.List<TalentQueryTagLikeDetailListResponseBodyResultLikeDetails> likeDetails;

        @NameInMap("nextCursor")
        public Long nextCursor;

        public static TalentQueryTagLikeDetailListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentQueryTagLikeDetailListResponseBodyResult self = new TalentQueryTagLikeDetailListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentQueryTagLikeDetailListResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public TalentQueryTagLikeDetailListResponseBodyResult setLikeDetails(java.util.List<TalentQueryTagLikeDetailListResponseBodyResultLikeDetails> likeDetails) {
            this.likeDetails = likeDetails;
            return this;
        }
        public java.util.List<TalentQueryTagLikeDetailListResponseBodyResultLikeDetails> getLikeDetails() {
            return this.likeDetails;
        }

        public TalentQueryTagLikeDetailListResponseBodyResult setNextCursor(Long nextCursor) {
            this.nextCursor = nextCursor;
            return this;
        }
        public Long getNextCursor() {
            return this.nextCursor;
        }

    }

}
