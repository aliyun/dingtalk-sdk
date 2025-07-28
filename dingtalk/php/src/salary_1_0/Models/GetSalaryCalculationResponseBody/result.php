<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\GetSalaryCalculationResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $calStatus;

    /**
     * @example 2025-06-30
     *
     * @var string
     */
    public $endDate;

    /**
     * @example 2025-06-01
     *
     * @var string
     */
    public $startDate;

    /**
     * @example NONE
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'calStatus' => 'calStatus',
        'endDate' => 'endDate',
        'startDate' => 'startDate',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->calStatus) {
            $res['calStatus'] = $this->calStatus;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
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
        if (isset($map['calStatus'])) {
            $model->calStatus = $map['calStatus'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
