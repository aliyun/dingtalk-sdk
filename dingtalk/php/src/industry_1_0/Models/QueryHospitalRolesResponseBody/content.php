<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalRolesResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 修改时间
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description 主键
     *
     * @var int
     */
    public $id;

    /**
     * @description 是否已删除，默认0未删除，1已删除
     *
     * @var int
     */
    public $isDeleted;

    /**
     * @description 角色关联权限点是否只读
     *
     * @var int
     */
    public $readOnly;

    /**
     * @description 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 角色编码
     *
     * @var string
     */
    public $roleCode;

    /**
     * @description 角色名称
     *
     * @var string
     */
    public $roleName;

    /**
     * @description 排序，数字越小越靠前，默认0
     *
     * @var int
     */
    public $sort;
    protected $_name = [
        'gmtCreate' => 'gmtCreate',
        'id'        => 'id',
        'isDeleted' => 'isDeleted',
        'readOnly'  => 'readOnly',
        'remark'    => 'remark',
        'roleCode'  => 'roleCode',
        'roleName'  => 'roleName',
        'sort'      => 'sort',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->readOnly) {
            $res['readOnly'] = $this->readOnly;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->roleCode) {
            $res['roleCode'] = $this->roleCode;
        }
        if (null !== $this->roleName) {
            $res['roleName'] = $this->roleName;
        }
        if (null !== $this->sort) {
            $res['sort'] = $this->sort;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['readOnly'])) {
            $model->readOnly = $map['readOnly'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['roleCode'])) {
            $model->roleCode = $map['roleCode'];
        }
        if (isset($map['roleName'])) {
            $model->roleName = $map['roleName'];
        }
        if (isset($map['sort'])) {
            $model->sort = $map['sort'];
        }

        return $model;
    }
}
