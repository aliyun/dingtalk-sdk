<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryBenefitInventoryResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 2000
     *
     * @var int
     */
    public $totalQuota;

    /**
     * @example 10
     *
     * @var int
     */
    public $usedQuota;
    protected $_name = [
        'totalQuota' => 'totalQuota',
        'usedQuota'  => 'usedQuota',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->totalQuota) {
            $res['totalQuota'] = $this->totalQuota;
        }
        if (null !== $this->usedQuota) {
            $res['usedQuota'] = $this->usedQuota;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['totalQuota'])) {
            $model->totalQuota = $map['totalQuota'];
        }
        if (isset($map['usedQuota'])) {
            $model->usedQuota = $map['usedQuota'];
        }

        return $model;
    }
}
