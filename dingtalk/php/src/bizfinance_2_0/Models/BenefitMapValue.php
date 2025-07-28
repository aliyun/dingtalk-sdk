<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class BenefitMapValue extends Model
{
    /**
     * @var bool
     */
    public $canUse;

    /**
     * @var int
     */
    public $canUseQuota;

    /**
     * @var int
     */
    public $usedQuota;
    protected $_name = [
        'canUse' => 'canUse',
        'canUseQuota' => 'canUseQuota',
        'usedQuota' => 'usedQuota',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->canUse) {
            $res['canUse'] = $this->canUse;
        }
        if (null !== $this->canUseQuota) {
            $res['canUseQuota'] = $this->canUseQuota;
        }
        if (null !== $this->usedQuota) {
            $res['usedQuota'] = $this->usedQuota;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BenefitMapValue
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['canUse'])) {
            $model->canUse = $map['canUse'];
        }
        if (isset($map['canUseQuota'])) {
            $model->canUseQuota = $map['canUseQuota'];
        }
        if (isset($map['usedQuota'])) {
            $model->usedQuota = $map['usedQuota'];
        }

        return $model;
    }
}
