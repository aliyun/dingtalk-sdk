<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateOrderRequest\detailList;
use AlibabaCloud\Tea\Model;

class CreateOrderRequest extends Model
{
    /**
     * @description 设备序列号
     *
     * @var string
     */
    public $sn;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 录脸token
     *
     * @var string
     */
    public $ftoken;

    /**
     * @description 交易加签
     *
     * @var string
     */
    public $terminalParams;

    /**
     * @description 应付价格
     *
     * @var int
     */
    public $totalAmount;

    /**
     * @description 实付金额（优惠计算后）
     *
     * @var int
     */
    public $actualAmount;

    /**
     * @description 订单明细信息，来源于商户系统或APP的商品信息。
     *
     * @var detailList[]
     */
    public $detailList;
    protected $_name = [
        'sn'             => 'sn',
        'userId'         => 'userId',
        'ftoken'         => 'ftoken',
        'terminalParams' => 'terminalParams',
        'totalAmount'    => 'totalAmount',
        'actualAmount'   => 'actualAmount',
        'detailList'     => 'detailList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->ftoken) {
            $res['ftoken'] = $this->ftoken;
        }
        if (null !== $this->terminalParams) {
            $res['terminalParams'] = $this->terminalParams;
        }
        if (null !== $this->totalAmount) {
            $res['totalAmount'] = $this->totalAmount;
        }
        if (null !== $this->actualAmount) {
            $res['actualAmount'] = $this->actualAmount;
        }
        if (null !== $this->detailList) {
            $res['detailList'] = [];
            if (null !== $this->detailList && \is_array($this->detailList)) {
                $n = 0;
                foreach ($this->detailList as $item) {
                    $res['detailList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['ftoken'])) {
            $model->ftoken = $map['ftoken'];
        }
        if (isset($map['terminalParams'])) {
            $model->terminalParams = $map['terminalParams'];
        }
        if (isset($map['totalAmount'])) {
            $model->totalAmount = $map['totalAmount'];
        }
        if (isset($map['actualAmount'])) {
            $model->actualAmount = $map['actualAmount'];
        }
        if (isset($map['detailList'])) {
            if (!empty($map['detailList'])) {
                $model->detailList = [];
                $n                 = 0;
                foreach ($map['detailList'] as $item) {
                    $model->detailList[$n++] = null !== $item ? detailList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
