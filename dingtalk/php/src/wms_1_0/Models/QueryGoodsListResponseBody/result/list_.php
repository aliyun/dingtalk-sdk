<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwms_1_0\Models\QueryGoodsListResponseBody\result;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 衣服
     *
     * @var string
     */
    public $goodsName;

    /**
     * @description This parameter is required.
     *
     * @example 0001
     *
     * @var string
     */
    public $goodsNo;

    /**
     * @description This parameter is required.
     *
     * @example abcdse-dse-example
     *
     * @var string
     */
    public $instanceId;

    /**
     * @description This parameter is required.
     *
     * @example XXL
     *
     * @var string
     */
    public $productSpecs;

    /**
     * @description This parameter is required.
     *
     * @example 件
     *
     * @var string
     */
    public $unit;
    protected $_name = [
        'goodsName'    => 'goodsName',
        'goodsNo'      => 'goodsNo',
        'instanceId'   => 'instanceId',
        'productSpecs' => 'productSpecs',
        'unit'         => 'unit',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->goodsName) {
            $res['goodsName'] = $this->goodsName;
        }
        if (null !== $this->goodsNo) {
            $res['goodsNo'] = $this->goodsNo;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->productSpecs) {
            $res['productSpecs'] = $this->productSpecs;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['goodsName'])) {
            $model->goodsName = $map['goodsName'];
        }
        if (isset($map['goodsNo'])) {
            $model->goodsNo = $map['goodsNo'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['productSpecs'])) {
            $model->productSpecs = $map['productSpecs'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }

        return $model;
    }
}
