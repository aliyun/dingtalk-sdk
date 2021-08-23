<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDeptResponseBody extends Model
{
    /**
     * @description 在父部门中的次序值
     *
     * @var int
     */
    public $order;

    /**
     * @description 部门id
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 部门名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 父部门id
     *
     * @var int
     */
    public $parentId;

    /**
     * @description 部门是否来自关联组织
     *
     * @var bool
     */
    public $fromUnionOrg;
    protected $_name = [
        'order'        => 'order',
        'deptId'       => 'deptId',
        'name'         => 'name',
        'parentId'     => 'parentId',
        'fromUnionOrg' => 'fromUnionOrg',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->parentId) {
            $res['parentId'] = $this->parentId;
        }
        if (null !== $this->fromUnionOrg) {
            $res['fromUnionOrg'] = $this->fromUnionOrg;
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
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['parentId'])) {
            $model->parentId = $map['parentId'];
        }
        if (isset($map['fromUnionOrg'])) {
            $model->fromUnionOrg = $map['fromUnionOrg'];
        }

        return $model;
    }
}
