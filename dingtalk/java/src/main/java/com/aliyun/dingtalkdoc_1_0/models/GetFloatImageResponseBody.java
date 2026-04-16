// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetFloatImageResponseBody extends TeaModel {
    @NameInMap("result")
    public GetFloatImageResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetFloatImageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFloatImageResponseBody self = new GetFloatImageResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFloatImageResponseBody setResult(GetFloatImageResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetFloatImageResponseBodyResult getResult() {
        return this.result;
    }

    public GetFloatImageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetFloatImageResponseBodyResultAnchor extends TeaModel {
        @NameInMap("col")
        public Integer col;

        @NameInMap("row")
        public Integer row;

        public static GetFloatImageResponseBodyResultAnchor build(java.util.Map<String, ?> map) throws Exception {
            GetFloatImageResponseBodyResultAnchor self = new GetFloatImageResponseBodyResultAnchor();
            return TeaModel.build(map, self);
        }

        public GetFloatImageResponseBodyResultAnchor setCol(Integer col) {
            this.col = col;
            return this;
        }
        public Integer getCol() {
            return this.col;
        }

        public GetFloatImageResponseBodyResultAnchor setRow(Integer row) {
            this.row = row;
            return this;
        }
        public Integer getRow() {
            return this.row;
        }

    }

    public static class GetFloatImageResponseBodyResultCoordinate extends TeaModel {
        @NameInMap("height")
        public Double height;

        @NameInMap("offsetX")
        public Double offsetX;

        @NameInMap("offsetY")
        public Double offsetY;

        @NameInMap("width")
        public Double width;

        public static GetFloatImageResponseBodyResultCoordinate build(java.util.Map<String, ?> map) throws Exception {
            GetFloatImageResponseBodyResultCoordinate self = new GetFloatImageResponseBodyResultCoordinate();
            return TeaModel.build(map, self);
        }

        public GetFloatImageResponseBodyResultCoordinate setHeight(Double height) {
            this.height = height;
            return this;
        }
        public Double getHeight() {
            return this.height;
        }

        public GetFloatImageResponseBodyResultCoordinate setOffsetX(Double offsetX) {
            this.offsetX = offsetX;
            return this;
        }
        public Double getOffsetX() {
            return this.offsetX;
        }

        public GetFloatImageResponseBodyResultCoordinate setOffsetY(Double offsetY) {
            this.offsetY = offsetY;
            return this;
        }
        public Double getOffsetY() {
            return this.offsetY;
        }

        public GetFloatImageResponseBodyResultCoordinate setWidth(Double width) {
            this.width = width;
            return this;
        }
        public Double getWidth() {
            return this.width;
        }

    }

    public static class GetFloatImageResponseBodyResult extends TeaModel {
        @NameInMap("anchor")
        public GetFloatImageResponseBodyResultAnchor anchor;

        @NameInMap("coordinate")
        public GetFloatImageResponseBodyResultCoordinate coordinate;

        @NameInMap("id")
        public String id;

        @NameInMap("src")
        public String src;

        public static GetFloatImageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetFloatImageResponseBodyResult self = new GetFloatImageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetFloatImageResponseBodyResult setAnchor(GetFloatImageResponseBodyResultAnchor anchor) {
            this.anchor = anchor;
            return this;
        }
        public GetFloatImageResponseBodyResultAnchor getAnchor() {
            return this.anchor;
        }

        public GetFloatImageResponseBodyResult setCoordinate(GetFloatImageResponseBodyResultCoordinate coordinate) {
            this.coordinate = coordinate;
            return this;
        }
        public GetFloatImageResponseBodyResultCoordinate getCoordinate() {
            return this.coordinate;
        }

        public GetFloatImageResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetFloatImageResponseBodyResult setSrc(String src) {
            this.src = src;
            return this;
        }
        public String getSrc() {
            return this.src;
        }

    }

}
