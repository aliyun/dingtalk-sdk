<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSalaryItemRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example SalaryItemGroupxxx
     *
     * @var string
     */
    public $salaryItemGroupId;
    protected $_name = [
        'salaryItemGroupId' => 'salaryItemGroupId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->salaryItemGroupId) {
            $res['salaryItemGroupId'] = $this->salaryItemGroupId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSalaryItemRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['salaryItemGroupId'])) {
            $model->salaryItemGroupId = $map['salaryItemGroupId'];
        }

        return $model;
    }
}
