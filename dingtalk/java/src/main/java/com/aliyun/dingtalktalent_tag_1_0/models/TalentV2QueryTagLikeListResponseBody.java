// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2QueryTagLikeListResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentV2QueryTagLikeListResponseBodyResult result;

    public static TalentV2QueryTagLikeListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentV2QueryTagLikeListResponseBody self = new TalentV2QueryTagLikeListResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentV2QueryTagLikeListResponseBody setResult(TalentV2QueryTagLikeListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentV2QueryTagLikeListResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentV2QueryTagLikeListResponseBodyResultTagLikes extends TeaModel {
        @NameInMap("hasLiked")
        public Boolean hasLiked;

        @NameInMap("likeCount")
        public Integer likeCount;

        @NameInMap("tagCode")
        public String tagCode;

        @NameInMap("tagName")
        public String tagName;

        public static TalentV2QueryTagLikeListResponseBodyResultTagLikes build(java.util.Map<String, ?> map) throws Exception {
            TalentV2QueryTagLikeListResponseBodyResultTagLikes self = new TalentV2QueryTagLikeListResponseBodyResultTagLikes();
            return TeaModel.build(map, self);
        }

        public TalentV2QueryTagLikeListResponseBodyResultTagLikes setHasLiked(Boolean hasLiked) {
            this.hasLiked = hasLiked;
            return this;
        }
        public Boolean getHasLiked() {
            return this.hasLiked;
        }

        public TalentV2QueryTagLikeListResponseBodyResultTagLikes setLikeCount(Integer likeCount) {
            this.likeCount = likeCount;
            return this;
        }
        public Integer getLikeCount() {
            return this.likeCount;
        }

        public TalentV2QueryTagLikeListResponseBodyResultTagLikes setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

        public TalentV2QueryTagLikeListResponseBodyResultTagLikes setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

    }

    public static class TalentV2QueryTagLikeListResponseBodyResult extends TeaModel {
        @NameInMap("tagLikes")
        public java.util.List<TalentV2QueryTagLikeListResponseBodyResultTagLikes> tagLikes;

        public static TalentV2QueryTagLikeListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentV2QueryTagLikeListResponseBodyResult self = new TalentV2QueryTagLikeListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentV2QueryTagLikeListResponseBodyResult setTagLikes(java.util.List<TalentV2QueryTagLikeListResponseBodyResultTagLikes> tagLikes) {
            this.tagLikes = tagLikes;
            return this;
        }
        public java.util.List<TalentV2QueryTagLikeListResponseBodyResultTagLikes> getTagLikes() {
            return this.tagLikes;
        }

    }

}
