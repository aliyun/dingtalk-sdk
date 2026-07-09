// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class SearchFileKeywordPositionsResponseBody extends TeaModel {
    @NameInMap("result")
    public SearchFileKeywordPositionsResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static SearchFileKeywordPositionsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchFileKeywordPositionsResponseBody self = new SearchFileKeywordPositionsResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchFileKeywordPositionsResponseBody setResult(SearchFileKeywordPositionsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SearchFileKeywordPositionsResponseBodyResult getResult() {
        return this.result;
    }

    public SearchFileKeywordPositionsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SearchFileKeywordPositionsResponseBodyResultDataPositions extends TeaModel {
        @NameInMap("index")
        public Integer index;

        @NameInMap("positionPage")
        public Integer positionPage;

        @NameInMap("positionX")
        public Double positionX;

        @NameInMap("positionY")
        public Double positionY;

        public static SearchFileKeywordPositionsResponseBodyResultDataPositions build(java.util.Map<String, ?> map) throws Exception {
            SearchFileKeywordPositionsResponseBodyResultDataPositions self = new SearchFileKeywordPositionsResponseBodyResultDataPositions();
            return TeaModel.build(map, self);
        }

        public SearchFileKeywordPositionsResponseBodyResultDataPositions setIndex(Integer index) {
            this.index = index;
            return this;
        }
        public Integer getIndex() {
            return this.index;
        }

        public SearchFileKeywordPositionsResponseBodyResultDataPositions setPositionPage(Integer positionPage) {
            this.positionPage = positionPage;
            return this;
        }
        public Integer getPositionPage() {
            return this.positionPage;
        }

        public SearchFileKeywordPositionsResponseBodyResultDataPositions setPositionX(Double positionX) {
            this.positionX = positionX;
            return this;
        }
        public Double getPositionX() {
            return this.positionX;
        }

        public SearchFileKeywordPositionsResponseBodyResultDataPositions setPositionY(Double positionY) {
            this.positionY = positionY;
            return this;
        }
        public Double getPositionY() {
            return this.positionY;
        }

    }

    public static class SearchFileKeywordPositionsResponseBodyResultData extends TeaModel {
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("keyword")
        public String keyword;

        @NameInMap("positions")
        public java.util.List<SearchFileKeywordPositionsResponseBodyResultDataPositions> positions;

        @NameInMap("totalCount")
        public Integer totalCount;

        public static SearchFileKeywordPositionsResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            SearchFileKeywordPositionsResponseBodyResultData self = new SearchFileKeywordPositionsResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public SearchFileKeywordPositionsResponseBodyResultData setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public SearchFileKeywordPositionsResponseBodyResultData setKeyword(String keyword) {
            this.keyword = keyword;
            return this;
        }
        public String getKeyword() {
            return this.keyword;
        }

        public SearchFileKeywordPositionsResponseBodyResultData setPositions(java.util.List<SearchFileKeywordPositionsResponseBodyResultDataPositions> positions) {
            this.positions = positions;
            return this;
        }
        public java.util.List<SearchFileKeywordPositionsResponseBodyResultDataPositions> getPositions() {
            return this.positions;
        }

        public SearchFileKeywordPositionsResponseBodyResultData setTotalCount(Integer totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Integer getTotalCount() {
            return this.totalCount;
        }

    }

    public static class SearchFileKeywordPositionsResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public SearchFileKeywordPositionsResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static SearchFileKeywordPositionsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SearchFileKeywordPositionsResponseBodyResult self = new SearchFileKeywordPositionsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SearchFileKeywordPositionsResponseBodyResult setData(SearchFileKeywordPositionsResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public SearchFileKeywordPositionsResponseBodyResultData getData() {
            return this.data;
        }

        public SearchFileKeywordPositionsResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
