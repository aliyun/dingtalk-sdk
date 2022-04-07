<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CustomizeContactDeptUpdateRequest extends Model
{
    /**
     * @description 自定义通讯录Code
     *
     * @var string
     */
    public $code;

    /**
     * @description 部门Id
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 部门主管列表
     *
     * @var string[]
     */
    public $managerIdList;

    /**
     * @description 部门名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 部门排序
     *
     * @var int
     */
    public $order;

    /**
     * @description 上级部门Id
     *
     * @var int
     */
    public $parentDeptId;
    protected $_name = [
        'code'          => 'code',
        'deptId'        => 'deptId',
        'managerIdList' => 'managerIdList',
        'name'          => 'name',
        'order'         => 'order',
        'parentDeptId'  => 'parentDeptId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->managerIdList) {
            $res['managerIdList'] = $this->managerIdList;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->parentDeptId) {
            $res['parentDeptId'] = $this->parentDeptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CustomizeContactDeptUpdateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['managerIdList'])) {
            if (!empty($map['managerIdList'])) {
                $model->managerIdList = $map['managerIdList'];
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['parentDeptId'])) {
            $model->parentDeptId = $map['parentDeptId'];
        }

        return $model;
    }
}
