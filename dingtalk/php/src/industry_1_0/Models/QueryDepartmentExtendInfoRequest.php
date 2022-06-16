<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryDepartmentExtendInfoRequest extends Model
{
    /**
     * @description 科室或医疗组code
     *
     * @var int
     */
    public $deptCode;

    /**
     * @description 扩展属性code
     *
     * @var string
     */
    public $propCode;
    protected $_name = [
        'deptCode' => 'deptCode',
        'propCode' => 'propCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptCode) {
            $res['deptCode'] = $this->deptCode;
        }
        if (null !== $this->propCode) {
            $res['propCode'] = $this->propCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryDepartmentExtendInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptCode'])) {
            $model->deptCode = $map['deptCode'];
        }
        if (isset($map['propCode'])) {
            $model->propCode = $map['propCode'];
        }

        return $model;
    }
}
