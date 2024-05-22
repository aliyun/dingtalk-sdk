<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetEmployeeRosterByFieldRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $appAgentId;

    /**
     * @var string[]
     */
    public $fieldFilterList;

    /**
     * @var bool
     */
    public $text2SelectConvert;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'appAgentId'         => 'appAgentId',
        'fieldFilterList'    => 'fieldFilterList',
        'text2SelectConvert' => 'text2SelectConvert',
        'userIdList'         => 'userIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appAgentId) {
            $res['appAgentId'] = $this->appAgentId;
        }
        if (null !== $this->fieldFilterList) {
            $res['fieldFilterList'] = $this->fieldFilterList;
        }
        if (null !== $this->text2SelectConvert) {
            $res['text2SelectConvert'] = $this->text2SelectConvert;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetEmployeeRosterByFieldRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appAgentId'])) {
            $model->appAgentId = $map['appAgentId'];
        }
        if (isset($map['fieldFilterList'])) {
            if (!empty($map['fieldFilterList'])) {
                $model->fieldFilterList = $map['fieldFilterList'];
            }
        }
        if (isset($map['text2SelectConvert'])) {
            $model->text2SelectConvert = $map['text2SelectConvert'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }

        return $model;
    }
}
