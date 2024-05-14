<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateSpaceRequest\shareScope;
use AlibabaCloud\Tea\Model;

class CreateSpaceRequest extends Model
{
    /**
     * @example 这里是知识库的简介
     *
     * @var string
     */
    public $description;

    /**
     * @example https://img.alicdn.com/imgextra/i1/O1***.png
     *
     * @var string
     */
    public $icon;

    /**
     * @description This parameter is required.
     *
     * @example 测试知识库
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example YEp3JcM******UIbhwiE
     *
     * @var string
     */
    public $operatorId;

    /**
     * @example l6gYG9****mo9Z
     *
     * @var string
     */
    public $sectionId;

    /**
     * @description This parameter is required.
     *
     * @var shareScope
     */
    public $shareScope;

    /**
     * @example 5YRB***GDAr
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
