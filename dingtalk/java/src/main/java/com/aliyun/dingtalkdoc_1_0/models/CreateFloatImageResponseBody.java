// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateFloatImageResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateFloatImageResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateFloatImageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateFloatImageResponseBody self = new CreateFloatImageResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateFloatImageResponseBody setResult(CreateFloatImageResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateFloatImageResponseBodyResult getResult() {
        return this.result;
    }

    public CreateFloatImageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateFloatImageResponseBodyResultAnchor extends TeaModel {
        @NameInMap("col")
        public Integer col;

        @NameInMap("row")
        public Integer row;

        public static CreateFloatImageResponseBodyResultAnchor build(java.util.Map<String, ?> map) throws Exception {
            CreateFloatImageResponseBodyResultAnchor self = new CreateFloatImageResponseBodyResultAnchor();
            return TeaModel.build(map, self);
        }

        public CreateFloatImageResponseBodyResultAnchor setCol(Integer col) {
            this.col = col;
            return this;
        }
        public Integer getCol() {
            return this.col;
        }

        public CreateFloatImageResponseBodyResultAnchor setRow(Integer row) {
            this.row = row;
            return this;
        }
        public Integer getRow() {
            return this.row;
        }

    }

    public static class CreateFloatImageResponseBodyResultCoordinate extends TeaModel {
        @NameInMap("height")
        public Double height;

        @NameInMap("offsetX")
        public Double offsetX;

        @NameInMap("offsetY")
        public Double offsetY;

        @NameInMap("width")
        public Double width;

        public static CreateFloatImageResponseBodyResultCoordinate build(java.util.Map<String, ?> map) throws Exception {
            CreateFloatImageResponseBodyResultCoordinate self = new CreateFloatImageResponseBodyResultCoordinate();
            return TeaModel.build(map, self);
        }

        public CreateFloatImageResponseBodyResultCoordinate setHeight(Double height) {
            this.height = height;
            return this;
        }
        public Double getHeight() {
            return this.height;
        }

        public CreateFloatImageResponseBodyResultCoordinate setOffsetX(Double offsetX) {
            this.offsetX = offsetX;
            return this;
        }
        public Double getOffsetX() {
            return this.offsetX;
        }

        public CreateFloatImageResponseBodyResultCoordinate setOffsetY(Double offsetY) {
            this.offsetY = offsetY;
            return this;
        }
        public Double getOffsetY() {
            return this.offsetY;
        }

        public CreateFloatImageResponseBodyResultCoordinate setWidth(Double width) {
            this.width = width;
            return this;
        }
        public Double getWidth() {
            return this.width;
        }

    }

    public static class CreateFloatImageResponseBodyResult extends TeaModel {
        @NameInMap("anchor")
        public CreateFloatImageResponseBodyResultAnchor anchor;

        @NameInMap("coordinate")
        public CreateFloatImageResponseBodyResultCoordinate coordinate;

        @NameInMap("id")
        public String id;

        @NameInMap("src")
        public String src;

        public static CreateFloatImageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateFloatImageResponseBodyResult self = new CreateFloatImageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateFloatImageResponseBodyResult setAnchor(CreateFloatImageResponseBodyResultAnchor anchor) {
            this.anchor = anchor;
            return this;
        }
        public CreateFloatImageResponseBodyResultAnchor getAnchor() {
            return this.anchor;
        }

        public CreateFloatImageResponseBodyResult setCoordinate(CreateFloatImageResponseBodyResultCoordinate coordinate) {
            this.coordinate = coordinate;
            return this;
        }
        public CreateFloatImageResponseBodyResultCoordinate getCoordinate() {
            return this.coordinate;
        }

        public CreateFloatImageResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateFloatImageResponseBodyResult setSrc(String src) {
            this.src = src;
            return this;
        }
        public String getSrc() {
            return this.src;
        }

    }

}
