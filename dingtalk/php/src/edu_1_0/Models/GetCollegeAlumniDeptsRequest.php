<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCollegeAlumniDeptsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $deptId;

    /**
     * @description This parameter is required.
     *
     * @example staff234
     *
     * @var string
     */
    public $operator;
    protected $_name = [
        'deptId' => 'deptId',
        'operator' => 'operator',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCollegeAlumniDeptsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }

        return $model;
    }
}
