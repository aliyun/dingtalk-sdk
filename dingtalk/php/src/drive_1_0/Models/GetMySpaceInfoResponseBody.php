<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetMySpaceInfoResponseBody extends Model
{
    /**
     * @description 空间id
     *
     * @var string
     */
    public $spaceId;

    /**
     * @description 空间名称
     *
     * @var string
     */
    public $spaceName;

    /**
     * @description 空间类型
     *
     * @var string
     */
    public $spaceType;

    /**
     * @description 容量
     *
     * @var int
     */
    public $quota;

    /**
     * @description 已使用容量
     *
     * @var int
     */
    public $usedQuota;

    /**
     * @description 授权模式
     *
     * @var string
     */
    public $permissionMode;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $modifyTime;
    protected $_name = [
        'spaceId'        => 'spaceId',
        'spaceName'      => 'spaceName',
        'spaceType'      => 'spaceType',
        'quota'          => 'quota',
        'usedQuota'      => 'usedQuota',
        'permissionMode' => 'permissionMode',
        'createTime'     => 'createTime',
        'modifyTime'     => 'modifyTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->spaceName) {
            $res['spaceName'] = $this->spaceName;
        }
        if (null !== $this->spaceType) {
            $res['spaceType'] = $this->spaceType;
        }
        if (null !== $this->quota) {
            $res['quota'] = $this->quota;
        }
        if (null !== $this->usedQuota) {
            $res['usedQuota'] = $this->usedQuota;
        }
        if (null !== $this->permissionMode) {
            $res['permissionMode'] = $this->permissionMode;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->modifyTime) {
            $res['modifyTime'] = $this->modifyTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMySpaceInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['spaceName'])) {
            $model->spaceName = $map['spaceName'];
        }
        if (isset($map['spaceType'])) {
            $model->spaceType = $map['spaceType'];
        }
        if (isset($map['quota'])) {
            $model->quota = $map['quota'];
        }
        if (isset($map['usedQuota'])) {
            $model->usedQuota = $map['usedQuota'];
        }
        if (isset($map['permissionMode'])) {
            $model->permissionMode = $map['permissionMode'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['modifyTime'])) {
            $model->modifyTime = $map['modifyTime'];
        }

        return $model;
    }
}