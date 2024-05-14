<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ManagementModifySpaceResponseBody;

use AlibabaCloud\Tea\Model;

class spaces extends Model
{
    /**
     * @description Use the UTC time format: yyyy-MM-ddTHH:mmZ
     *
     * @var string
     */
    public $createTime;

    /**
     * @description Use the UTC time format: yyyy-MM-ddTHH:mmZ
     *
     * @var string
     */
    public $modifyTime;

    /**
     * @var string
     */
    public $permissionMode;

    /**
     * @var int
     */
    public $quota;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $spaceId;

    /**
     * @var string
     */
    public $spaceName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $spaceType;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $usedQuota;
    protected $_name = [
        'createTime'     => 'createTime',
        'modifyTime'     => 'modifyTime',
        'permissionMode' => 'permissionMode',
        'quota'          => 'quota',
        'spaceId'        => 'spaceId',
        'spaceName'      => 'spaceName',
        'spaceType'      => 'spaceType',
        'usedQuota'      => 'usedQuota',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->modifyTime) {
            $res['modifyTime'] = $this->modifyTime;
        }
        if (null !== $this->permissionMode) {
            $res['permissionMode'] = $this->permissionMode;
        }
        if (null !== $this->quota) {
            $res['quota'] = $this->quota;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->spaceName) {
            $res['spaceName'] = $this->spaceName;
        }
        if (null !== $this->spaceType) {
            $res['spaceType'] = $this->spaceType;
        }
        if (null !== $this->usedQuota) {
            $res['usedQuota'] = $this->usedQuota;
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
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['modifyTime'])) {
            $model->modifyTime = $map['modifyTime'];
        }
        if (isset($map['permissionMode'])) {
            $model->permissionMode = $map['permissionMode'];
        }
        if (isset($map['quota'])) {
            $model->quota = $map['quota'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['spaceName'])) {
            $model->spaceName = $map['spaceName'];
        }
        if (isset($map['spaceType'])) {
            $model->spaceType = $map['spaceType'];
        }
        if (isset($map['usedQuota'])) {
            $model->usedQuota = $map['usedQuota'];
        }

        return $model;
    }
}
