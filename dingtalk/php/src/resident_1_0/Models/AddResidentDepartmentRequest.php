<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddResidentDepartmentRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 第一网格组
     *
     * @var string
     */
    public $departmentName;

    /**
     * @example true
     *
     * @var bool
     */
    public $isResidenceGroup;

    /**
     * @description This parameter is required.
     *
     * @example 12345
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
