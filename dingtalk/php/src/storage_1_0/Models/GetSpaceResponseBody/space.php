<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetSpaceResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetSpaceResponseBody\space\capabilities;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetSpaceResponseBody\space\partitions;
use AlibabaCloud\Tea\Model;

class space extends Model
{
    /**
     * @example app_id
     *
     * @var string
     */
    public $appId;

    /**
     * @var capabilities
     */
    public $capabilities;

    /**
     * @example corp_id
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 2022-01-01T10:00:00Z
     *
     * @var string
     */
    public $createTime;

    /**
     * @example creator_id
     *
     * @var string
     */
    public $creatorId;

    /**
     * @example space_id
     *
     * @var string
     */
    public $id;

    /**
     * @example 2022-01-01T10:00:00Z
     *
     * @var string
     */
    public $modifiedTime;

    /**
     * @example modifier_id
     *
     * @var string
     */
    public $modifierId;

    /**
     * @example space_name
     *
     * @var string
     */
    public $name;

    /**
     * @example owner_id
     *
     * @var string
     */
    public $ownerId;

    /**
     * @example USER
     *
     * @var string
     */
    public $ownerType;

    /**
     * @var partitions[]
     */
    public $partitions;

    /**
     * @example 1048576
     *
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

    /**
     * @example NORMAL
     *
     * @var string
     */
    public $status;

    /**
     * @example 1024
     *
     * @var int
     */
    public $usedQuota;
    protected $_name = [
        'appId'        => 'appId',
        'capabilities' => 'capabilities',
        'corpId'       => 'corpId',
        'createTime'   => 'createTime',
        'creatorId'    => 'creatorId',
        'id'           => 'id',
        'modifiedTime' => 'modifiedTime',
        'modifierId'   => 'modifierId',
        'name'         => 'name',
        'ownerId'      => 'ownerId',
        'ownerType'    => 'ownerType',
        'partitions'   => 'partitions',
        'quota'        => 'quota',
        'scene'        => 'scene',
        'sceneId'      => 'sceneId',
        'status'       => 'status',
        'usedQuota'    => 'usedQuota',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->capabilities) {
            $res['capabilities'] = null !== $this->capabilities ? $this->capabilities->toMap() : null;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->modifierId) {
            $res['modifierId'] = $this->modifierId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->ownerId) {
            $res['ownerId'] = $this->ownerId;
        }
        if (null !== $this->ownerType) {
            $res['ownerType'] = $this->ownerType;
        }
        if (null !== $this->partitions) {
            $res['partitions'] = [];
            if (null !== $this->partitions && \is_array($this->partitions)) {
                $n = 0;
                foreach ($this->partitions as $item) {
                    $res['partitions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->usedQuota) {
            $res['usedQuota'] = $this->usedQuota;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return space
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['capabilities'])) {
            $model->capabilities = capabilities::fromMap($map['capabilities']);
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }
        if (isset($map['modifierId'])) {
            $model->modifierId = $map['modifierId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['ownerId'])) {
            $model->ownerId = $map['ownerId'];
        }
        if (isset($map['ownerType'])) {
            $model->ownerType = $map['ownerType'];
        }
        if (isset($map['partitions'])) {
            if (!empty($map['partitions'])) {
                $model->partitions = [];
                $n                 = 0;
                foreach ($map['partitions'] as $item) {
                    $model->partitions[$n++] = null !== $item ? partitions::fromMap($item) : $item;
                }
            }
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
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['usedQuota'])) {
            $model->usedQuota = $map['usedQuota'];
        }

        return $model;
    }
}
