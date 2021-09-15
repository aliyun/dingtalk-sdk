<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateResidenceRequest extends Model
{
    /**
     * @description 家庭管理员用户id
     *
     * @var string
     */
    public $managerUserId;

    /**
     * @description 户名字
     *
     * @var string
     */
    public $name;

    /**
     * @description 组id
     *
     * @var int
     */
    public $departmentId;

    /**
     * @description 所属网格
     *
     * @var string
     */
    public $grid;

    /**
     * @description 家庭电话
     *
     * @var string
     */
    public $homeTel;

    /**
     * @description 是否是贫困户
     *
     * @var bool
     */
    public $destitute;

    /**
     * @description 组id
     *
     * @var int
     */
    public $parentDepartmentId;
    protected $_name = [
        'managerUserId'      => 'managerUserId',
        'name'               => 'name',
        'departmentId'       => 'departmentId',
        'grid'               => 'grid',
        'homeTel'            => 'homeTel',
        'destitute'          => 'destitute',
        'parentDepartmentId' => 'parentDepartmentId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->managerUserId) {
            $res['managerUserId'] = $this->managerUserId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }
        if (null !== $this->grid) {
            $res['grid'] = $this->grid;
        }
        if (null !== $this->homeTel) {
            $res['homeTel'] = $this->homeTel;
        }
        if (null !== $this->destitute) {
            $res['destitute'] = $this->destitute;
        }
        if (null !== $this->parentDepartmentId) {
            $res['parentDepartmentId'] = $this->parentDepartmentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateResidenceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['managerUserId'])) {
            $model->managerUserId = $map['managerUserId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['grid'])) {
            $model->grid = $map['grid'];
        }
        if (isset($map['homeTel'])) {
            $model->homeTel = $map['homeTel'];
        }
        if (isset($map['destitute'])) {
            $model->destitute = $map['destitute'];
        }
        if (isset($map['parentDepartmentId'])) {
            $model->parentDepartmentId = $map['parentDepartmentId'];
        }

        return $model;
    }
}
