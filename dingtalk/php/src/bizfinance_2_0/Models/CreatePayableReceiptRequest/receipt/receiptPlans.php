<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\CreatePayableReceiptRequest\receipt;

use AlibabaCloud\Tea\Model;

class receiptPlans extends Model
{
    /**
     * @var string
     */
    public $planAmount;

    /**
     * @var int
     */
    public $planDate;

    /**
     * @var string
     */
    public $planRemark;

    /**
     * @var string
     */
    public $uuid;
    protected $_name = [
        'planAmount' => 'planAmount',
        'planDate' => 'planDate',
        'planRemark' => 'planRemark',
        'uuid' => 'uuid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->planAmount) {
            $res['planAmount'] = $this->planAmount;
        }
        if (null !== $this->planDate) {
            $res['planDate'] = $this->planDate;
        }
        if (null !== $this->planRemark) {
            $res['planRemark'] = $this->planRemark;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return receiptPlans
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['planAmount'])) {
            $model->planAmount = $map['planAmount'];
        }
        if (isset($map['planDate'])) {
            $model->planDate = $map['planDate'];
        }
        if (isset($map['planRemark'])) {
            $model->planRemark = $map['planRemark'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
