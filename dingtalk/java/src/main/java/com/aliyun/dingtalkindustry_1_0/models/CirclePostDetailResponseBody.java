// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CirclePostDetailResponseBody extends TeaModel {
    @NameInMap("result")
    public CirclePostDetailResponseBodyResult result;

    public static CirclePostDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CirclePostDetailResponseBody self = new CirclePostDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public CirclePostDetailResponseBody setResult(CirclePostDetailResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CirclePostDetailResponseBodyResult getResult() {
        return this.result;
    }

    public static class CirclePostDetailResponseBodyResultProducts extends TeaModel {
        @NameInMap("id")
        public Long id;

        @NameInMap("price")
        public Long price;

        @NameInMap("productCode")
        public String productCode;

        @NameInMap("productName")
        public String productName;

        public static CirclePostDetailResponseBodyResultProducts build(java.util.Map<String, ?> map) throws Exception {
            CirclePostDetailResponseBodyResultProducts self = new CirclePostDetailResponseBodyResultProducts();
            return TeaModel.build(map, self);
        }

        public CirclePostDetailResponseBodyResultProducts setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public CirclePostDetailResponseBodyResultProducts setPrice(Long price) {
            this.price = price;
            return this;
        }
        public Long getPrice() {
            return this.price;
        }

        public CirclePostDetailResponseBodyResultProducts setProductCode(String productCode) {
            this.productCode = productCode;
            return this;
        }
        public String getProductCode() {
            return this.productCode;
        }

        public CirclePostDetailResponseBodyResultProducts setProductName(String productName) {
            this.productName = productName;
            return this;
        }
        public String getProductName() {
            return this.productName;
        }

    }

    public static class CirclePostDetailResponseBodyResultTagList extends TeaModel {
        @NameInMap("tagColor")
        public String tagColor;

        @NameInMap("tagId")
        public Long tagId;

        @NameInMap("tagName")
        public String tagName;

        public static CirclePostDetailResponseBodyResultTagList build(java.util.Map<String, ?> map) throws Exception {
            CirclePostDetailResponseBodyResultTagList self = new CirclePostDetailResponseBodyResultTagList();
            return TeaModel.build(map, self);
        }

        public CirclePostDetailResponseBodyResultTagList setTagColor(String tagColor) {
            this.tagColor = tagColor;
            return this;
        }
        public String getTagColor() {
            return this.tagColor;
        }

        public CirclePostDetailResponseBodyResultTagList setTagId(Long tagId) {
            this.tagId = tagId;
            return this;
        }
        public Long getTagId() {
            return this.tagId;
        }

        public CirclePostDetailResponseBodyResultTagList setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

    }

    public static class CirclePostDetailResponseBodyResult extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("deptName")
        public String deptName;

        @NameInMap("dislikeCount")
        public Long dislikeCount;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("likeCount")
        public Long likeCount;

        @NameInMap("mediaUrlList")
        public java.util.List<String> mediaUrlList;

        @NameInMap("postId")
        public Long postId;

        @NameInMap("postType")
        public String postType;

        @NameInMap("products")
        public java.util.List<CirclePostDetailResponseBodyResultProducts> products;

        @NameInMap("status")
        public String status;

        @NameInMap("tagList")
        public java.util.List<CirclePostDetailResponseBodyResultTagList> tagList;

        @NameInMap("title")
        public String title;

        @NameInMap("userId")
        public String userId;

        @NameInMap("userName")
        public String userName;

        @NameInMap("viewCount")
        public Long viewCount;

        public static CirclePostDetailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CirclePostDetailResponseBodyResult self = new CirclePostDetailResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CirclePostDetailResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public CirclePostDetailResponseBodyResult setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public CirclePostDetailResponseBodyResult setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public CirclePostDetailResponseBodyResult setDislikeCount(Long dislikeCount) {
            this.dislikeCount = dislikeCount;
            return this;
        }
        public Long getDislikeCount() {
            return this.dislikeCount;
        }

        public CirclePostDetailResponseBodyResult setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public CirclePostDetailResponseBodyResult setLikeCount(Long likeCount) {
            this.likeCount = likeCount;
            return this;
        }
        public Long getLikeCount() {
            return this.likeCount;
        }

        public CirclePostDetailResponseBodyResult setMediaUrlList(java.util.List<String> mediaUrlList) {
            this.mediaUrlList = mediaUrlList;
            return this;
        }
        public java.util.List<String> getMediaUrlList() {
            return this.mediaUrlList;
        }

        public CirclePostDetailResponseBodyResult setPostId(Long postId) {
            this.postId = postId;
            return this;
        }
        public Long getPostId() {
            return this.postId;
        }

        public CirclePostDetailResponseBodyResult setPostType(String postType) {
            this.postType = postType;
            return this;
        }
        public String getPostType() {
            return this.postType;
        }

        public CirclePostDetailResponseBodyResult setProducts(java.util.List<CirclePostDetailResponseBodyResultProducts> products) {
            this.products = products;
            return this;
        }
        public java.util.List<CirclePostDetailResponseBodyResultProducts> getProducts() {
            return this.products;
        }

        public CirclePostDetailResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public CirclePostDetailResponseBodyResult setTagList(java.util.List<CirclePostDetailResponseBodyResultTagList> tagList) {
            this.tagList = tagList;
            return this;
        }
        public java.util.List<CirclePostDetailResponseBodyResultTagList> getTagList() {
            return this.tagList;
        }

        public CirclePostDetailResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public CirclePostDetailResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public CirclePostDetailResponseBodyResult setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

        public CirclePostDetailResponseBodyResult setViewCount(Long viewCount) {
            this.viewCount = viewCount;
            return this;
        }
        public Long getViewCount() {
            return this.viewCount;
        }

    }

}
