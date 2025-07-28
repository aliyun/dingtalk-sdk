<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models;

use AlibabaCloud\Tea\Model;

class UndoDeletionRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $bizIdList;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $redDotRelationId;

    /**
     * @description This parameter is required.
     *
     * @example workbench_component
     *
     * @var string
     */
    public $redDotType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizIdList' => 'bizIdList',
        'redDotRelationId' => 'redDotRelationId',
        'redDotType' => 'redDotType',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizIdList) {
            $res['bizIdList'] = $this->bizIdList;
        }
        if (null !== $this->redDotRelationId) {
            $res['redDotRelationId'] = $this->redDotRelationId;
        }
        if (null !== $this->redDotType) {
            $res['redDotType'] = $this->redDotType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UndoDeletionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizIdList'])) {
            if (!empty($map['bizIdList'])) {
                $model->bizIdList = $map['bizIdList'];
            }
        }
        if (isset($map['redDotRelationId'])) {
            $model->redDotRelationId = $map['redDotRelationId'];
        }
        if (isset($map['redDotType'])) {
            $model->redDotType = $map['redDotType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
