<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryEduAssetSpacesResponseBody;

use AlibabaCloud\Tea\Model;

class spaces extends Model
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
     * @description 空间容量
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
     * @description 权限类型acl：acl授权；custom：自定义授权
     *
     * @var string
     */
    public $permissionMode;

    /**
     * @description 创建时间的时间戳
     *
     * @var int
     */
    public $createTimeMillis;

    /**
     * @description 修改时间的时间戳
     *
     * @var int
     */
    public $modifyTimeMillis;
    protected $_name = [
        'spaceId'          => 'spaceId',
        'spaceName'        => 'spaceName',
        'spaceType'        => 'spaceType',
        'quota'            => 'quota',
        'usedQuota'        => 'usedQuota',
        'permissionMode'   => 'permissionMode',
        'createTimeMillis' => 'createTimeMillis',
        'modifyTimeMillis' => 'modifyTimeMillis',
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
        if (null !== $this->createTimeMillis) {
            $res['createTimeMillis'] = $this->createTimeMillis;
        }
        if (null !== $this->modifyTimeMillis) {
            $res['modifyTimeMillis'] = $this->modifyTimeMillis;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return spaces
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
        if (isset($map['createTimeMillis'])) {
            $model->createTimeMillis = $map['createTimeMillis'];
        }
        if (isset($map['modifyTimeMillis'])) {
            $model->modifyTimeMillis = $map['modifyTimeMillis'];
        }

        return $model;
    }
}
