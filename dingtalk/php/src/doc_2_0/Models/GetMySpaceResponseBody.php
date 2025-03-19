<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetMySpaceResponseBody extends Model
{
    /**
     * @example 2022-01-01T10:00:00Z
     *
     * @var string
     */
    public $createTime;

    /**
     * @example 2022-01-01T10:00:00Z
     *
     * @var string
     */
    public $modifyTime;

    /**
     * @example 1L
     *
     * @var int
     */
    public $quota;

    /**
     * @example space_id
     *
     * @var string
     */
    public $spaceId;

    /**
     * @example space_name
     *
     * @var string
     */
    public $spaceName;

    /**
     * @example personal|org|custom|unknown
     *
     * @var string
     */
    public $spaceType;

    /**
     * @example 1L
     *
     * @var int
     */
    public $usedQuota;
    protected $_name = [
        'createTime' => 'createTime',
        'modifyTime' => 'modifyTime',
        'quota' => 'quota',
        'spaceId' => 'spaceId',
        'spaceName' => 'spaceName',
        'spaceType' => 'spaceType',
        'usedQuota' => 'usedQuota',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->modifyTime) {
            $res['modifyTime'] = $this->modifyTime;
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
     * @return GetMySpaceResponseBody
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
