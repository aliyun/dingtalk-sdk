<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateClassGroupCardRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bizCardId;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $classId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $groupTypeList;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $isFinalUpdate;

    /**
     * @var mixed[][]
     */
    public $privateCardData;

    /**
     * @var string[]
     */
    public $publicCardData;
    protected $_name = [
        'bizCardId' => 'bizCardId',
        'classId' => 'classId',
        'groupTypeList' => 'groupTypeList',
        'isFinalUpdate' => 'isFinalUpdate',
        'privateCardData' => 'privateCardData',
        'publicCardData' => 'publicCardData',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCardId) {
            $res['bizCardId'] = $this->bizCardId;
        }
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->groupTypeList) {
            $res['groupTypeList'] = $this->groupTypeList;
        }
        if (null !== $this->isFinalUpdate) {
            $res['isFinalUpdate'] = $this->isFinalUpdate;
        }
        if (null !== $this->privateCardData) {
            $res['privateCardData'] = $this->privateCardData;
        }
        if (null !== $this->publicCardData) {
            $res['publicCardData'] = $this->publicCardData;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateClassGroupCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCardId'])) {
            $model->bizCardId = $map['bizCardId'];
        }
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['groupTypeList'])) {
            if (!empty($map['groupTypeList'])) {
                $model->groupTypeList = $map['groupTypeList'];
            }
        }
        if (isset($map['isFinalUpdate'])) {
            $model->isFinalUpdate = $map['isFinalUpdate'];
        }
        if (isset($map['privateCardData'])) {
            $model->privateCardData = $map['privateCardData'];
        }
        if (isset($map['publicCardData'])) {
            $model->publicCardData = $map['publicCardData'];
        }

        return $model;
    }
}
