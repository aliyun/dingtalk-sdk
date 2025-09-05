<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\UpdateVacationQuotaResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\UpdateVacationQuotaResponseBody\result\quota;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var quota
     */
    public $quota;

    /**
     * @example 假期类型不存在
     *
     * @var string
     */
    public $reason;
    protected $_name = [
        'quota' => 'quota',
        'reason' => 'reason',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->quota) {
            $res['quota'] = null !== $this->quota ? $this->quota->toMap() : null;
        }
        if (null !== $this->reason) {
            $res['reason'] = $this->reason;
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
        if (isset($map['quota'])) {
            $model->quota = quota::fromMap($map['quota']);
        }
        if (isset($map['reason'])) {
            $model->reason = $map['reason'];
        }

        return $model;
    }
}
