// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateFloatImageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("anchor")
    public CreateFloatImageRequestAnchor anchor;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("coordinate")
    public CreateFloatImageRequestCoordinate coordinate;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("src")
    public String src;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static CreateFloatImageRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateFloatImageRequest self = new CreateFloatImageRequest();
        return TeaModel.build(map, self);
    }

    public CreateFloatImageRequest setAnchor(CreateFloatImageRequestAnchor anchor) {
        this.anchor = anchor;
        return this;
    }
    public CreateFloatImageRequestAnchor getAnchor() {
        return this.anchor;
    }

    public CreateFloatImageRequest setCoordinate(CreateFloatImageRequestCoordinate coordinate) {
        this.coordinate = coordinate;
        return this;
    }
    public CreateFloatImageRequestCoordinate getCoordinate() {
        return this.coordinate;
    }

    public CreateFloatImageRequest setSrc(String src) {
        this.src = src;
        return this;
    }
    public String getSrc() {
        return this.src;
    }

    public CreateFloatImageRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class CreateFloatImageRequestAnchor extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("col")
        public Integer col;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("row")
        public Integer row;

        public static CreateFloatImageRequestAnchor build(java.util.Map<String, ?> map) throws Exception {
            CreateFloatImageRequestAnchor self = new CreateFloatImageRequestAnchor();
            return TeaModel.build(map, self);
        }

        public CreateFloatImageRequestAnchor setCol(Integer col) {
            this.col = col;
            return this;
        }
        public Integer getCol() {
            return this.col;
        }

        public CreateFloatImageRequestAnchor setRow(Integer row) {
            this.row = row;
            return this;
        }
        public Integer getRow() {
            return this.row;
        }

    }

    public static class CreateFloatImageRequestCoordinate extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("height")
        public Double height;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("offsetX")
        public Double offsetX;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("offsetY")
        public Double offsetY;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("width")
        public Double width;

        public static CreateFloatImageRequestCoordinate build(java.util.Map<String, ?> map) throws Exception {
            CreateFloatImageRequestCoordinate self = new CreateFloatImageRequestCoordinate();
            return TeaModel.build(map, self);
        }

        public CreateFloatImageRequestCoordinate setHeight(Double height) {
            this.height = height;
            return this;
        }
        public Double getHeight() {
            return this.height;
        }

        public CreateFloatImageRequestCoordinate setOffsetX(Double offsetX) {
            this.offsetX = offsetX;
            return this;
        }
        public Double getOffsetX() {
            return this.offsetX;
        }

        public CreateFloatImageRequestCoordinate setOffsetY(Double offsetY) {
            this.offsetY = offsetY;
            return this;
        }
        public Double getOffsetY() {
            return this.offsetY;
        }

        public CreateFloatImageRequestCoordinate setWidth(Double width) {
            this.width = width;
            return this;
        }
        public Double getWidth() {
            return this.width;
        }

    }

}
