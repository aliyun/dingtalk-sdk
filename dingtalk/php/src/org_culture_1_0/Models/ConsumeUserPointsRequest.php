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

    /**
     * @description 用途，可用值：OPEN_EMP_POINT_CONSUME_DEFAULT-默认扣减，OPEN_EMP_POINT_PUNISH_CONSUME-惩罚扣减；默认为: OPEN_EMP_POINT_CONSUME_DEFAULT
     *
     * @var string
     */
    public $usage;
    protected $_name = [
        'amount' => 'amount',
        'outId'  => 'outId',
        'remark' => 'remark',
        'usage'  => 'usage',
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
        if (null !== $this->usage) {
            $res['usage'] = $this->usage;
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
        if (isset($map['usage'])) {
            $model->usage = $map['usage'];
        }

        return $model;
    }
}
