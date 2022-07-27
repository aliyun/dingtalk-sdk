<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddSpaceRequest;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddSpaceRequest\option\capabilities;
use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @description 空间能力项, 默认表示不设置拓展能力项
     *
     * @var capabilities
     */
    public $capabilities;

    /**
     * @description 空间名称，默认无空间名称
     *
     * @var string
     */
    public $name;

    /**
     * @description owner类型, 空间Owner可以是用户或应用
     * USER
     * @var string
     */
    public $ownerType;

    /**
     * @description 空间能使用最大容量, 默认表示无最大容量
     *
     * @var int
     */
    public $quota;

    /**
     * @description 空间场景，详见 Space.scene 字段. 不指定默认值是default
     * default
     * @var string
     */
    public $scene;

    /**
     * @description 空间场景Id，详见 Space.sceneId 字段. 不指定默认值是0
     * 0
     * @var string
     */
    public $sceneId;
    protected $_name = [
        'capabilities' => 'capabilities',
        'name'         => 'name',
        'ownerType'    => 'ownerType',
        'quota'        => 'quota',
        'scene'        => 'scene',
        'sceneId'      => 'sceneId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->capabilities) {
            $res['capabilities'] = null !== $this->capabilities ? $this->capabilities->toMap() : null;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->ownerType) {
            $res['ownerType'] = $this->ownerType;
        }
        if (null !== $this->quota) {
            $res['quota'] = $this->quota;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->sceneId) {
            $res['sceneId'] = $this->sceneId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['capabilities'])) {
            $model->capabilities = capabilities::fromMap($map['capabilities']);
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['ownerType'])) {
            $model->ownerType = $map['ownerType'];
        }
        if (isset($map['quota'])) {
            $model->quota = $map['quota'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['sceneId'])) {
            $model->sceneId = $map['sceneId'];
        }

        return $model;
    }
}
