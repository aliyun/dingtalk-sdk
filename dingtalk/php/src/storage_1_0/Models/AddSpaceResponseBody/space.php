<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddSpaceResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddSpaceResponseBody\space\capabilities;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddSpaceResponseBody\space\partitions;
use AlibabaCloud\Tea\Model;

class space extends Model
{
    /**
     * @description 开放平台应用appId
     *
     * @var string
     */
    public $appId;

    /**
     * @description 空间能力项
     *
     * @var capabilities
     */
    public $capabilities;

    /**
     * @description 空间归属企业的id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 创建者id
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 空间id
     *
     * @var string
     */
    public $id;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $modifiedTime;

    /**
     * @description 修改者id
     *
     * @var string
     */
    public $modifierId;

    /**
     * @description 空间名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 所有者id, 根据ownerType定义, 确定值的所属类型
     *
     * @var string
     */
    public $ownerId;

    /**
     * @description owner类型
     * APP: App类型
     * @var string
     */
    public $ownerType;

    /**
     * @description 分区容量信息
     * 2
     * @var partitions[]
     */
    public $partitions;

    /**
     * @description 容量上限
     * 建议使用分区上容量信息字段
     * @var int
     */
    public $quota;

    /**
     * @description 业务场景，可以自定义，表示多个不同空间的聚合，可以提供对特定场景做能力设计、容量管理，如根据场景来做搜索或查询。
     * default
     * @var string
     */
    public $scene;

    /**
     * @description 关联业务id, 配合scene一起使用。创建空间时，不指定sceneId， 默认值是0
     * 0
     * @var string
     */
    public $sceneId;

    /**
     * @description 空间状态
     * DELETE: 已删除
     * @var string
     */
    public $status;

    /**
     * @description 已使用容量, 包含各分区已使用容量和
     * 建议使用分区上容量信息字段
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
