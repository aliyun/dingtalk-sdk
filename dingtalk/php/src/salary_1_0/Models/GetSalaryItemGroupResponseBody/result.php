<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\GetSalaryItemGroupResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example SalaryItemGroupIdxxx
     *
     * @var string
     */
    public $salaryItemGroupId;

    /**
     * @example 浮动薪资xx
     *
     * @var string
     */
    public $salaryItemGroupName;
    protected $_name = [
        'salaryItemGroupId' => 'salaryItemGroupId',
        'salaryItemGroupName' => 'salaryItemGroupName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->salaryItemGroupId) {
            $res['salaryItemGroupId'] = $this->salaryItemGroupId;
        }
        if (null !== $this->salaryItemGroupName) {
            $res['salaryItemGroupName'] = $this->salaryItemGroupName;
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
        if (isset($map['salaryItemGroupId'])) {
            $model->salaryItemGroupId = $map['salaryItemGroupId'];
        }
        if (isset($map['salaryItemGroupName'])) {
            $model->salaryItemGroupName = $map['salaryItemGroupName'];
        }

        return $model;
    }
}
