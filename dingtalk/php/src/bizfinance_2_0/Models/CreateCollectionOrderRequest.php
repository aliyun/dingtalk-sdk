<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class CreateCollectionOrderRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 0.01
     *
     * @var string
     */
    public $amount;

    /**
     * @description This parameter is required.
     *
     * @example a
     *
     * @var string
     */
    public $collectionInfoId;

    /**
     * @description This parameter is required.
     *
     * @example a
     *
     * @var string
     */
    public $instanceId;

    /**
     * @example 收款
     *
     * @var string
     */
    public $remark;
    protected $_name = [
        'amount' => 'amount',
        'collectionInfoId' => 'collectionInfoId',
        'instanceId' => 'instanceId',
        'remark' => 'remark',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->collectionInfoId) {
            $res['collectionInfoId'] = $this->collectionInfoId;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateCollectionOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['collectionInfoId'])) {
            $model->collectionInfoId = $map['collectionInfoId'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }

        return $model;
    }
}
