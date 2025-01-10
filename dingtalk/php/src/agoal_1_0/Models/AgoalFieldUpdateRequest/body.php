<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalFieldUpdateRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 662e006fe4b0f579bbcxxxxx
     *
     * @var string
     */
    public $entityId;

    /**
     * @description This parameter is required.
     *
     * @example OBJECTIVE
     *
     * @var string
     */
    public $entityType;

    /**
     * @description This parameter is required.
     *
     * @example title
     *
     * @var string
     */
    public $fieldCode;

    /**
     * @example 字段值
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'entityId'   => 'entityId',
        'entityType' => 'entityType',
        'fieldCode'  => 'fieldCode',
        'value'      => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->entityId) {
            $res['entityId'] = $this->entityId;
        }
        if (null !== $this->entityType) {
            $res['entityType'] = $this->entityType;
        }
        if (null !== $this->fieldCode) {
            $res['fieldCode'] = $this->fieldCode;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['entityId'])) {
            $model->entityId = $map['entityId'];
        }
        if (isset($map['entityType'])) {
            $model->entityType = $map['entityType'];
        }
        if (isset($map['fieldCode'])) {
            $model->fieldCode = $map['fieldCode'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
