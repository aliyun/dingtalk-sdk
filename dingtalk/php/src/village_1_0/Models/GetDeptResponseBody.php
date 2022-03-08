<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDeptResponseBody extends Model
{
    /**
     * @description 下属组织的部门ID
     *
     * @var int
     */
    public $departmentId;

    /**
     * @description 部门名称
     *
     * @var string
     */
    public $departmentName;

    /**
     * @description 部门是否来自关联组织
     *
     * @var bool
     */
    public $fromUnionOrg;

    /**
     * @description 在父部门中的次序值
     *
     * @var int
     */
    public $order;

    /**
     * @description 父部门id
     *
     * @var int
     */
    public $parentDepartmentId;
    protected $_name = [
        'departmentId'       => 'departmentId',
        'departmentName'     => 'departmentName',
        'fromUnionOrg'       => 'fromUnionOrg',
        'order'              => 'order',
        'parentDepartmentId' => 'parentDepartmentId',
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
        if (null !== $this->fromUnionOrg) {
            $res['fromUnionOrg'] = $this->fromUnionOrg;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->parentDepartmentId) {
            $res['parentDepartmentId'] = $this->parentDepartmentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDeptResponseBody
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
        if (isset($map['fromUnionOrg'])) {
            $model->fromUnionOrg = $map['fromUnionOrg'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['parentDepartmentId'])) {
            $model->parentDepartmentId = $map['parentDepartmentId'];
        }

        return $model;
    }
}
