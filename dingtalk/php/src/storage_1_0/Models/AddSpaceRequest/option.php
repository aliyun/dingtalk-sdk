<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddSpaceRequest;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddSpaceRequest\option\capabilities;
use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @var capabilities
     */
    public $capabilities;

    /**
     * @example space_name
     *
     * @var string
     */
    public $name;

    /**
     * @example USER
     *
     * @var string
     */
    public $ownerType;

    /**
     * @var int
     */
    public $quota;

    /**
     * @example scene
     *
     * @var string
     */
    public $scene;

    /**
     * @example scene_id
     *
     * @var string
     */
    public $sceneId;
    protected $_name = [
        'capabilities' => 'capabilities',
        'name' => 'name',
        'ownerType' => 'ownerType',
        'quota' => 'quota',
        'scene' => 'scene',
        'sceneId' => 'sceneId',
    ];

    public function validate() {}

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
