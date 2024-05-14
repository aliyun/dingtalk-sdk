<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models;

use AlibabaCloud\Tea\Model;

class ModifyWorkbenchBadgeRequest extends Model
{
    /**
     * @var string[]
     */
    public $bizIdList;

    /**
     * @var bool
     */
    public $isAdded;

    /**
     * @description This parameter is required.
     *
     * @example full
     *
     * @var string
     */
    public $modifyMode;

    /**
     * @description This parameter is required.
     *
     * @example 5000000004278081/test
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
     * @example 0123465
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizIdList'        => 'bizIdList',
        'isAdded'          => 'isAdded',
        'modifyMode'       => 'modifyMode',
        'redDotRelationId' => 'redDotRelationId',
        'redDotType'       => 'redDotType',
        'userId'           => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizIdList) {
            $res['bizIdList'] = $this->bizIdList;
        }
        if (null !== $this->isAdded) {
            $res['isAdded'] = $this->isAdded;
        }
        if (null !== $this->modifyMode) {
            $res['modifyMode'] = $this->modifyMode;
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
     * @return ModifyWorkbenchBadgeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizIdList'])) {
            if (!empty($map['bizIdList'])) {
                $model->bizIdList = $map['bizIdList'];
            }
        }
        if (isset($map['isAdded'])) {
            $model->isAdded = $map['isAdded'];
        }
        if (isset($map['modifyMode'])) {
            $model->modifyMode = $map['modifyMode'];
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
