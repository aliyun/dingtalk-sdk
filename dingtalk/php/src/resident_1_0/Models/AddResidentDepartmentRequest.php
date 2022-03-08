<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddResidentDepartmentRequest extends Model
{
    /**
     * @description 部门名字
     *
     * @var string
     */
    public $departmentName;

    /**
     * @description 是否为组
     *
     * @var bool
     */
    public $isResidenceGroup;

    /**
     * @description 父部门id
     *
     * @var int
     */
    public $parentDepartmentId;
    protected $_name = [
        'departmentName'     => 'departmentName',
        'isResidenceGroup'   => 'isResidenceGroup',
        'parentDepartmentId' => 'parentDepartmentId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->departmentName) {
            $res['departmentName'] = $this->departmentName;
        }
        if (null !== $this->isResidenceGroup) {
            $res['isResidenceGroup'] = $this->isResidenceGroup;
        }
        if (null !== $this->parentDepartmentId) {
            $res['parentDepartmentId'] = $this->parentDepartmentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddResidentDepartmentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['departmentName'])) {
            $model->departmentName = $map['departmentName'];
        }
        if (isset($map['isResidenceGroup'])) {
            $model->isResidenceGroup = $map['isResidenceGroup'];
        }
        if (isset($map['parentDepartmentId'])) {
            $model->parentDepartmentId = $map['parentDepartmentId'];
        }

        return $model;
    }
}
