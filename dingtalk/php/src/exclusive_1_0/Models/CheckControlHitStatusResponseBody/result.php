<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CheckControlHitStatusResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string[]
     */
    public $controlList;

    /**
     * @var int
     */
    public $controlStatus;

    /**
     * @var string
     */
    public $reason;
    protected $_name = [
        'controlList' => 'controlList',
        'controlStatus' => 'controlStatus',
        'reason' => 'reason',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->controlList) {
            $res['controlList'] = $this->controlList;
        }
        if (null !== $this->controlStatus) {
            $res['controlStatus'] = $this->controlStatus;
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
        if (isset($map['controlList'])) {
            if (!empty($map['controlList'])) {
                $model->controlList = $map['controlList'];
            }
        }
        if (isset($map['controlStatus'])) {
            $model->controlStatus = $map['controlStatus'];
        }
        if (isset($map['reason'])) {
            $model->reason = $map['reason'];
        }

        return $model;
    }
}
