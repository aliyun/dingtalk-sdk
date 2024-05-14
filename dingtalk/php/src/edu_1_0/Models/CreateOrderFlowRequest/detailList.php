<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateOrderFlowRequest;

use AlibabaCloud\Tea\Model;

class detailList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 100
     *
     * @var int
     */
    public $actualAmount;

    /**
     * @description This parameter is required.
     *
     * @example 100
     *
     * @var int
     */
    public $itemAmount;

    /**
     * @example 123
     *
     * @var int
     */
    public $itemId;

    /**
     * @description This parameter is required.
     *
     * @example 测试商品
     *
     * @var string
     */
    public $itemName;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $scene;
    protected $_name = [
        'actualAmount' => 'actualAmount',
        'itemAmount'   => 'itemAmount',
        'itemId'       => 'itemId',
        'itemName'     => 'itemName',
        'scene'        => 'scene',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actualAmount) {
            $res['actualAmount'] = $this->actualAmount;
        }
        if (null !== $this->itemAmount) {
            $res['itemAmount'] = $this->itemAmount;
        }
        if (null !== $this->itemId) {
            $res['itemId'] = $this->itemId;
        }
        if (null !== $this->itemName) {
            $res['itemName'] = $this->itemName;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
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
        if (isset($map['actualAmount'])) {
            $model->actualAmount = $map['actualAmount'];
        }
        if (isset($map['itemAmount'])) {
            $model->itemAmount = $map['itemAmount'];
        }
        if (isset($map['itemId'])) {
            $model->itemId = $map['itemId'];
        }
        if (isset($map['itemName'])) {
            $model->itemName = $map['itemName'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }

        return $model;
    }
}
