<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateSpaceRequest\shareScope;
use AlibabaCloud\Tea\Model;

class CreateSpaceRequest extends Model
{
    /**
     * @description 知识库简介。
     * 最大长度50。
     * @var string
     */
    public $description;

    /**
     * @description 知识库图标。
     *
     * @var string
     */
    public $icon;

    /**
     * @description 知识库名称。
     * 最大长度50。
     * @var string
     */
    public $name;

    /**
     * @description 操作人unionId。
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 知识库分组id。只有选择了所属小组的情况下，才需要设置知识库分组。
     *
     * @var string
     */
    public $sectionId;

    /**
     * @description 公开范围。
     *
     * @var shareScope
     */
    public $shareScope;

    /**
     * @description 所属小组id。
     *
     * @var string
     */
    public $teamId;
    protected $_name = [
        'description' => 'description',
        'icon'        => 'icon',
        'name'        => 'name',
        'operatorId'  => 'operatorId',
        'sectionId'   => 'sectionId',
        'shareScope'  => 'shareScope',
        'teamId'      => 'teamId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->sectionId) {
            $res['sectionId'] = $this->sectionId;
        }
        if (null !== $this->shareScope) {
            $res['shareScope'] = null !== $this->shareScope ? $this->shareScope->toMap() : null;
        }
        if (null !== $this->teamId) {
            $res['teamId'] = $this->teamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateSpaceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['sectionId'])) {
            $model->sectionId = $map['sectionId'];
        }
        if (isset($map['shareScope'])) {
            $model->shareScope = shareScope::fromMap($map['shareScope']);
        }
        if (isset($map['teamId'])) {
            $model->teamId = $map['teamId'];
        }

        return $model;
    }
}
