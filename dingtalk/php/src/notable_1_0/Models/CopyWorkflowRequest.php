<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\Tea\Model;

class CopyWorkflowRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $flowId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $flowVersionId;

    /**
     * @var bool
     */
    public $isSystem;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $sourceBaseId;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'flowId' => 'flowId',
        'flowVersionId' => 'flowVersionId',
        'isSystem' => 'isSystem',
        'sourceBaseId' => 'sourceBaseId',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->flowId) {
            $res['flowId'] = $this->flowId;
        }
        if (null !== $this->flowVersionId) {
            $res['flowVersionId'] = $this->flowVersionId;
        }
        if (null !== $this->isSystem) {
            $res['isSystem'] = $this->isSystem;
        }
        if (null !== $this->sourceBaseId) {
            $res['sourceBaseId'] = $this->sourceBaseId;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CopyWorkflowRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['flowId'])) {
            $model->flowId = $map['flowId'];
        }
        if (isset($map['flowVersionId'])) {
            $model->flowVersionId = $map['flowVersionId'];
        }
        if (isset($map['isSystem'])) {
            $model->isSystem = $map['isSystem'];
        }
        if (isset($map['sourceBaseId'])) {
            $model->sourceBaseId = $map['sourceBaseId'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
