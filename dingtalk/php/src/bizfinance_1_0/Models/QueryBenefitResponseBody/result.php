<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryBenefitResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $remainQuota;

    /**
     * @var int
     */
    public $totalQuota;
    protected $_name = [
        'remainQuota' => 'remainQuota',
        'totalQuota' => 'totalQuota',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->remainQuota) {
            $res['remainQuota'] = $this->remainQuota;
        }
        if (null !== $this->totalQuota) {
            $res['totalQuota'] = $this->totalQuota;
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
        if (isset($map['remainQuota'])) {
            $model->remainQuota = $map['remainQuota'];
        }
        if (isset($map['totalQuota'])) {
            $model->totalQuota = $map['totalQuota'];
        }

        return $model;
    }
}
