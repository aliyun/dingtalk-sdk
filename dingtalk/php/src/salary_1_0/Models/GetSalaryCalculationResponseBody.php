<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\GetSalaryCalculationResponseBody\result;
use AlibabaCloud\Tea\Model;

class GetSalaryCalculationResponseBody extends Model
{
    /**
     * @var result
     */
    public $result;
    protected $_name = [
        'result' => 'result',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->result) {
            $res['result'] = null !== $this->result ? $this->result->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSalaryCalculationResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['result'])) {
            $model->result = result::fromMap($map['result']);
        }

        return $model;
    }
}
