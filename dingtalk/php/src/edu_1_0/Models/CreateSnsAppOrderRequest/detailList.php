<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSnsAppOrderRequest;

use AlibabaCloud\Tea\Model;

class detailList extends Model
{
    /**
     * @example 1234000
     *
     * @var string
     */
    public $goodsId;

    /**
     * @example 绘画图书
     *
     * @var string
     */
    public $goodsName;

    /**
     * @example 1
     *
     * @var int
     */
    public $goodsPrice;

    /**
     * @example 1
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
