// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2QueryTagLikeDetailListResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentV2QueryTagLikeDetailListResponseBodyResult result;

    public static TalentV2QueryTagLikeDetailListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentV2QueryTagLikeDetailListResponseBody self = new TalentV2QueryTagLikeDetailListResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentV2QueryTagLikeDetailListResponseBody setResult(TalentV2QueryTagLikeDetailListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentV2QueryTagLikeDetailListResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentV2QueryTagLikeDetailListResponseBodyResultLikeDetails extends TeaModel {
        @NameInMap("likeTimestamp")
        public Long likeTimestamp;

        @NameInMap("operatorUserId")
        public String operatorUserId;

        public static TalentV2QueryTagLikeDetailListResponseBodyResultLikeDetails build(java.util.Map<String, ?> map) throws Exception {
            TalentV2QueryTagLikeDetailListResponseBodyResultLikeDetails self = new TalentV2QueryTagLikeDetailListResponseBodyResultLikeDetails();
            return TeaModel.build(map, self);
        }

        public TalentV2QueryTagLikeDetailListResponseBodyResultLikeDetails setLikeTimestamp(Long likeTimestamp) {
            this.likeTimestamp = likeTimestamp;
            return this;
        }
        public Long getLikeTimestamp() {
            return this.likeTimestamp;
        }

        public TalentV2QueryTagLikeDetailListResponseBodyResultLikeDetails setOperatorUserId(String operatorUserId) {
            this.operatorUserId = operatorUserId;
            return this;
        }
        public String getOperatorUserId() {
            return this.operatorUserId;
        }

    }

    public static class TalentV2QueryTagLikeDetailListResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("likeDetails")
        public java.util.List<TalentV2QueryTagLikeDetailListResponseBodyResultLikeDetails> likeDetails;

        @NameInMap("nextCursor")
        public Long nextCursor;

        public static TalentV2QueryTagLikeDetailListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentV2QueryTagLikeDetailListResponseBodyResult self = new TalentV2QueryTagLikeDetailListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentV2QueryTagLikeDetailListResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public TalentV2QueryTagLikeDetailListResponseBodyResult setLikeDetails(java.util.List<TalentV2QueryTagLikeDetailListResponseBodyResultLikeDetails> likeDetails) {
            this.likeDetails = likeDetails;
            return this;
        }
        public java.util.List<TalentV2QueryTagLikeDetailListResponseBodyResultLikeDetails> getLikeDetails() {
            return this.likeDetails;
        }

        public TalentV2QueryTagLikeDetailListResponseBodyResult setNextCursor(Long nextCursor) {
            this.nextCursor = nextCursor;
            return this;
        }
        public Long getNextCursor() {
            return this.nextCursor;
        }

    }

}
