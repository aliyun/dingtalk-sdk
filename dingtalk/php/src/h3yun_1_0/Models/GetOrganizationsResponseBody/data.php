<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetOrganizationsResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 部门编码
     *
     * @var string
     */
    public $code;

    /**
     * @description 描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 部门id
     *
     * @var string
     */
    public $id;

    /**
     * @description 部门名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 父级部门id
     *
     * @var string
     */
    public $parentId;

    /**
     * @description 排序值
     *
     * @var int
     */
    public $sortKey;

    /**
     * @description 组织类型。Company=公司，OrganizationUnit=组织单元
     *
     * @var string
     */
    public $unitType;
    protected $_name = [
        'code'        => 'code',
        'description' => 'description',
        'id'          => 'id',
        'name'        => 'name',
        'parentId'    => 'parentId',
        'sortKey'     => 'sortKey',
        'unitType'    => 'unitType',
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
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->parentId) {
            $res['parentId'] = $this->parentId;
        }
        if (null !== $this->sortKey) {
            $res['sortKey'] = $this->sortKey;
        }
        if (null !== $this->unitType) {
            $res['unitType'] = $this->unitType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['parentId'])) {
            $model->parentId = $map['parentId'];
        }
        if (isset($map['sortKey'])) {
            $model->sortKey = $map['sortKey'];
        }
        if (isset($map['unitType'])) {
            $model->unitType = $map['unitType'];
        }

        return $model;
    }
}
