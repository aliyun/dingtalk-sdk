<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateFulfilRecordRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1647503420000
     *
     * @var int
     */
    public $bizTime;

    /**
     * @description This parameter is required.
     *
     * @example {"key":"value"}
     *
     * @var string
     */
    public $extInfo;

    /**
     * @description This parameter is required.
     *
     * @example F123123
     *
     * @var string
     */
    public $faceId;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $scene;

    /**
     * @description This parameter is required.
     *
     * @example SN123456
     *
     * @var string
     */
    public $sn;

    /**
     * @description This parameter is required.
     *
     * @example 12312312444
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizTime' => 'bizTime',
        'extInfo' => 'extInfo',
        'faceId' => 'faceId',
        'scene' => 'scene',
        'sn' => 'sn',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizTime) {
            $res['bizTime'] = $this->bizTime;
        }
        if (null !== $this->extInfo) {
            $res['extInfo'] = $this->extInfo;
        }
        if (null !== $this->faceId) {
            $res['faceId'] = $this->faceId;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateFulfilRecordRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizTime'])) {
            $model->bizTime = $map['bizTime'];
        }
        if (isset($map['extInfo'])) {
            $model->extInfo = $map['extInfo'];
        }
        if (isset($map['faceId'])) {
            $model->faceId = $map['faceId'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
