<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeletePerfEvalRequest;

use AlibabaCloud\Tea\Model;

class params extends Model
{
    /**
     * @var string
     */
    public $perfPlanName;

    /**
     * @var string
     */
    public $period;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $workNo;
    protected $_name = [
        'perfPlanName' => 'perfPlanName',
        'period' => 'period',
        'workNo' => 'workNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->perfPlanName) {
            $res['perfPlanName'] = $this->perfPlanName;
        }
        if (null !== $this->period) {
            $res['period'] = $this->period;
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return params
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['perfPlanName'])) {
            $model->perfPlanName = $map['perfPlanName'];
        }
        if (isset($map['period'])) {
            $model->period = $map['period'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
