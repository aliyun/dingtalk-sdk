<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateAppOrderRequest;

use AlibabaCloud\Tea\Model;

class detailList extends Model
{
    /**
     * @description 商品id。
     *
     * @var string
     */
    public $goodsId;

    /**
     * @description 商品名称。
     *
     * @var string
     */
    public $goodsName;

    /**
     * @description 商品价格，单位分。
     *
     * @var int
     */
    public $goodsPrice;

    /**
     * @description 商品数量。
     *
     * @var int
     */
    public $goodsQuantity;
    protected $_name = [
        'goodsId'       => 'goodsId',
        'goodsName'     => 'goodsName',
        'goodsPrice'    => 'goodsPrice',
        'goodsQuantity' => 'goodsQuantity',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->goodsId) {
            $res['goodsId'] = $this->goodsId;
        }
        if (null !== $this->goodsName) {
            $res['goodsName'] = $this->goodsName;
        }
        if (null !== $this->goodsPrice) {
            $res['goodsPrice'] = $this->goodsPrice;
        }
        if (null !== $this->goodsQuantity) {
            $res['goodsQuantity'] = $this->goodsQuantity;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return detailList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['goodsId'])) {
            $model->goodsId = $map['goodsId'];
        }
        if (isset($map['goodsName'])) {
            $model->goodsName = $map['goodsName'];
        }
        if (isset($map['goodsPrice'])) {
            $model->goodsPrice = $map['goodsPrice'];
        }
        if (isset($map['goodsQuantity'])) {
            $model->goodsQuantity = $map['goodsQuantity'];
        }

        return $model;
    }
}
