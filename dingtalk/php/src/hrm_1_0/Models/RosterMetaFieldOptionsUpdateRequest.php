<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class RosterMetaFieldOptionsUpdateRequest extends Model
{
    /**
     * @var int
     */
    public $appAgentId;

    /**
     * @description This parameter is required.
     *
     * @example sys05-contractType
     *
     * @var string
     */
    public $fieldCode;

    /**
     * @description This parameter is required.
     *
     * @example sys05
     *
     * @var string
     */
    public $groupId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $labels;

    /**
     * @description This parameter is required.
     *
     * @example OPTIONS_ADD
     *
     * @var string
     */
    public $modifyType;
    protected $_name = [
        'appAgentId' => 'appAgentId',
        'fieldCode' => 'fieldCode',
        'groupId' => 'groupId',
        'labels' => 'labels',
        'modifyType' => 'modifyType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appAgentId) {
            $res['appAgentId'] = $this->appAgentId;
        }
        if (null !== $this->fieldCode) {
            $res['fieldCode'] = $this->fieldCode;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->labels) {
            $res['labels'] = $this->labels;
        }
        if (null !== $this->modifyType) {
            $res['modifyType'] = $this->modifyType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RosterMetaFieldOptionsUpdateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appAgentId'])) {
            $model->appAgentId = $map['appAgentId'];
        }
        if (isset($map['fieldCode'])) {
            $model->fieldCode = $map['fieldCode'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['labels'])) {
            if (!empty($map['labels'])) {
                $model->labels = $map['labels'];
            }
        }
        if (isset($map['modifyType'])) {
            $model->modifyType = $map['modifyType'];
        }

        return $model;
    }
}
