<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentSubDeptsResponseBody;

use AlibabaCloud\Tea\Model;

class departmentList extends Model
{
    /**
     * @description 下属组织的部门ID
     *
     * @var int
     */
    public $departmentId;

    /**
     * @description 组户名称
     *
     * @var string
     */
    public $departmentName;

    /**
     * @description 父部门ID
     *
     * @var int
     */
    public $superDepartmentId;
    protected $_name = [
        'departmentId'      => 'departmentId',
        'departmentName'    => 'departmentName',
        'superDepartmentId' => 'superDepartmentId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }
        if (null !== $this->departmentName) {
            $res['departmentName'] = $this->departmentName;
        }
        if (null !== $this->superDepartmentId) {
            $res['superDepartmentId'] = $this->superDepartmentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return departmentList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['departmentName'])) {
            $model->departmentName = $map['departmentName'];
        }
        if (isset($map['superDepartmentId'])) {
            $model->superDepartmentId = $map['superDepartmentId'];
        }

        return $model;
    }
}
