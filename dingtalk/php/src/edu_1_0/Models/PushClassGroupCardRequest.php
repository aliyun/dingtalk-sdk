<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class PushClassGroupCardRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $classId;

    /**
     * @var string[]
     */
    public $groupTypeList;

    /**
     * @var mixed[][]
     */
    public $privateCardData;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $publicCardData;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $senderUserId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $studentUserIds;
    protected $_name = [
        'bizCode' => 'bizCode',
        'classId' => 'classId',
        'groupTypeList' => 'groupTypeList',
        'privateCardData' => 'privateCardData',
        'publicCardData' => 'publicCardData',
        'senderUserId' => 'senderUserId',
        'studentUserIds' => 'studentUserIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->groupTypeList) {
            $res['groupTypeList'] = $this->groupTypeList;
        }
        if (null !== $this->privateCardData) {
            $res['privateCardData'] = $this->privateCardData;
        }
        if (null !== $this->publicCardData) {
            $res['publicCardData'] = $this->publicCardData;
        }
        if (null !== $this->senderUserId) {
            $res['senderUserId'] = $this->senderUserId;
        }
        if (null !== $this->studentUserIds) {
            $res['studentUserIds'] = $this->studentUserIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PushClassGroupCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['groupTypeList'])) {
            if (!empty($map['groupTypeList'])) {
                $model->groupTypeList = $map['groupTypeList'];
            }
        }
        if (isset($map['privateCardData'])) {
            $model->privateCardData = $map['privateCardData'];
        }
        if (isset($map['publicCardData'])) {
            $model->publicCardData = $map['publicCardData'];
        }
        if (isset($map['senderUserId'])) {
            $model->senderUserId = $map['senderUserId'];
        }
        if (isset($map['studentUserIds'])) {
            if (!empty($map['studentUserIds'])) {
                $model->studentUserIds = $map['studentUserIds'];
            }
        }

        return $model;
    }
}
