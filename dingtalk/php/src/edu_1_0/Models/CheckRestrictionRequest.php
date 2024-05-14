<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CheckRestrictionRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $actualAmount;

    /**
     * @description This parameter is required.
     *
     * @example 123
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
     * @example 123
     *
     * @var string
     */
    public $sn;

    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'actualAmount' => 'actualAmount',
        'faceId'       => 'faceId',
        'scene'        => 'scene',
        'sn'           => 'sn',
        'userId'       => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actualAmount) {
            $res['actualAmount'] = $this->actualAmount;
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
     * @return CheckRestrictionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actualAmount'])) {
            $model->actualAmount = $map['actualAmount'];
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
