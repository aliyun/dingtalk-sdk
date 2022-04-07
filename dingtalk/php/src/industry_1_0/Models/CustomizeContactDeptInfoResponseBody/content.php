<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptInfoResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
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
    public $id;

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

    /**
     * @description 引用的内部通讯录部门Id
     *
     * @var int
     */
    public $refId;

    /**
     * @description 部门类型 0:普通部门 1:引用部门
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'code'          => 'code',
        'id'            => 'id',
        'managerIdList' => 'managerIdList',
        'name'          => 'name',
        'order'         => 'order',
        'parentDeptId'  => 'parentDeptId',
        'refId'         => 'refId',
        'type'          => 'type',
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
        if (null !== $this->id) {
            $res['id'] = $this->id;
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
        if (null !== $this->refId) {
            $res['refId'] = $this->refId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
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
        if (isset($map['refId'])) {
            $model->refId = $map['refId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
