<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListSalaryCalculationRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 2025-06
     *
     * @var string
     */
    public $date;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $pageIndex;

    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description This parameter is required.
     *
     * @example SalaryGroupXXX
     *
     * @var string
     */
    public $salaryGroupId;
    protected $_name = [
        'date' => 'date',
        'pageIndex' => 'pageIndex',
        'pageSize' => 'pageSize',
        'salaryGroupId' => 'salaryGroupId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->date) {
            $res['date'] = $this->date;
        }
        if (null !== $this->pageIndex) {
            $res['pageIndex'] = $this->pageIndex;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->salaryGroupId) {
            $res['salaryGroupId'] = $this->salaryGroupId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListSalaryCalculationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['date'])) {
            $model->date = $map['date'];
        }
        if (isset($map['pageIndex'])) {
            $model->pageIndex = $map['pageIndex'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['salaryGroupId'])) {
            $model->salaryGroupId = $map['salaryGroupId'];
        }

        return $model;
    }
}
