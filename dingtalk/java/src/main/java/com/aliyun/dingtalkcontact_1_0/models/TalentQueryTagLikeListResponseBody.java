// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentQueryTagLikeListResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentQueryTagLikeListResponseBodyResult result;

    public static TalentQueryTagLikeListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentQueryTagLikeListResponseBody self = new TalentQueryTagLikeListResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentQueryTagLikeListResponseBody setResult(TalentQueryTagLikeListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentQueryTagLikeListResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentQueryTagLikeListResponseBodyResultTagLikes extends TeaModel {
        @NameInMap("hasLiked")
        public Boolean hasLiked;

        @NameInMap("likeCount")
        public Integer likeCount;

        @NameInMap("tagCode")
        public String tagCode;

        @NameInMap("tagName")
        public String tagName;

        public static TalentQueryTagLikeListResponseBodyResultTagLikes build(java.util.Map<String, ?> map) throws Exception {
            TalentQueryTagLikeListResponseBodyResultTagLikes self = new TalentQueryTagLikeListResponseBodyResultTagLikes();
            return TeaModel.build(map, self);
        }

        public TalentQueryTagLikeListResponseBodyResultTagLikes setHasLiked(Boolean hasLiked) {
            this.hasLiked = hasLiked;
            return this;
        }
        public Boolean getHasLiked() {
            return this.hasLiked;
        }

        public TalentQueryTagLikeListResponseBodyResultTagLikes setLikeCount(Integer likeCount) {
            this.likeCount = likeCount;
            return this;
        }
        public Integer getLikeCount() {
            return this.likeCount;
        }

        public TalentQueryTagLikeListResponseBodyResultTagLikes setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

        public TalentQueryTagLikeListResponseBodyResultTagLikes setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

    }

    public static class TalentQueryTagLikeListResponseBodyResult extends TeaModel {
        @NameInMap("tagLikes")
        public java.util.List<TalentQueryTagLikeListResponseBodyResultTagLikes> tagLikes;

        public static TalentQueryTagLikeListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentQueryTagLikeListResponseBodyResult self = new TalentQueryTagLikeListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentQueryTagLikeListResponseBodyResult setTagLikes(java.util.List<TalentQueryTagLikeListResponseBodyResultTagLikes> tagLikes) {
            this.tagLikes = tagLikes;
            return this;
        }
        public java.util.List<TalentQueryTagLikeListResponseBodyResultTagLikes> getTagLikes() {
            return this.tagLikes;
        }

    }

}
