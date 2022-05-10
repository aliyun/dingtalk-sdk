<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models;

use AlibabaCloud\Tea\Model;

class ConsumeUserPointsRequest extends Model
{
    /**
     * @description 扣减积分数量，1～1000000
     *
     * @var int
     */
    public $amount;

    /**
     * @description 幂等外部ID，最大长度32个字符
     *
     * @var string
     */
    public $outId;

    /**
     * @description 备注，最长32个字符
     *
     * @var string
     */
    public $remark;
    protected $_name = [
        'amount' => 'amount',
        'outId'  => 'outId',
        'remark' => 'remark',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->outId) {
            $res['outId'] = $this->outId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ConsumeUserPointsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['outId'])) {
            $model->outId = $map['outId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }

        return $model;
    }
}
