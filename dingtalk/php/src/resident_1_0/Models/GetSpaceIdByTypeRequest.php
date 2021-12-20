<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSpaceIdByTypeRequest extends Model
{
    /**
     * @description 部门类型
     *
     * @var string
     */
    public $departmentType;
    protected $_name = [
        'departmentType' => 'departmentType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->departmentType) {
            $res['departmentType'] = $this->departmentType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSpaceIdByTypeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['departmentType'])) {
            $model->departmentType = $map['departmentType'];
        }

        return $model;
    }
}
