<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\StartProcessInstanceRequest\approvers;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\StartProcessInstanceRequest\formComponentValues;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\StartProcessInstanceRequest\targetSelectActioners;
use AlibabaCloud\Tea\Model;

class StartProcessInstanceRequest extends Model
{
    /**
     * @var approvers[]
     */
    public $approvers;

    /**
     * @var string[]
     */
    public $ccList;

    /**
     * @example START、FINISH、START_FINISH
     *
     * @var string
     */
    public $ccPosition;

    /**
     * @example 1
     *
     * @var int
     */
    public $deptId;

    /**
     * @description This parameter is required.
     *
     * @var formComponentValues[]
     */
    public $formComponentValues;

    /**
     * @example 41605932
     *
     * @var int
     */
    public $microappAgentId;

    /**
     * @description This parameter is required.
     *
     * @example manager432
     *
     * @var string
     */
    public $originatorUserId;

    /**
     * @description This parameter is required.
     *
     * @example PROC-EF6YJL35P2-SCKICSB7P750S0YISYKV3-xxxx-1
     *
     * @var string
     */
    public $processCode;

    /**
     * @var targetSelectActioners[]
     */
    public $targetSelectActioners;
    protected $_name = [
        'approvers'             => 'approvers',
        'ccList'                => 'ccList',
        'ccPosition'            => 'ccPosition',
        'deptId'                => 'deptId',
        'formComponentValues'   => 'formComponentValues',
        'microappAgentId'       => 'microappAgentId',
        'originatorUserId'      => 'originatorUserId',
        'processCode'           => 'processCode',
        'targetSelectActioners' => 'targetSelectActioners',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->approvers) {
            $res['approvers'] = [];
            if (null !== $this->approvers && \is_array($this->approvers)) {
                $n = 0;
                foreach ($this->approvers as $item) {
                    $res['approvers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->ccList) {
            $res['ccList'] = $this->ccList;
        }
        if (null !== $this->ccPosition) {
            $res['ccPosition'] = $this->ccPosition;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->formComponentValues) {
            $res['formComponentValues'] = [];
            if (null !== $this->formComponentValues && \is_array($this->formComponentValues)) {
                $n = 0;
                foreach ($this->formComponentValues as $item) {
                    $res['formComponentValues'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->microappAgentId) {
            $res['microappAgentId'] = $this->microappAgentId;
        }
        if (null !== $this->originatorUserId) {
            $res['originatorUserId'] = $this->originatorUserId;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->targetSelectActioners) {
            $res['targetSelectActioners'] = [];
            if (null !== $this->targetSelectActioners && \is_array($this->targetSelectActioners)) {
                $n = 0;
                foreach ($this->targetSelectActioners as $item) {
                    $res['targetSelectActioners'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return StartProcessInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['approvers'])) {
            if (!empty($map['approvers'])) {
                $model->approvers = [];
                $n                = 0;
                foreach ($map['approvers'] as $item) {
                    $model->approvers[$n++] = null !== $item ? approvers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['ccList'])) {
            if (!empty($map['ccList'])) {
                $model->ccList = $map['ccList'];
            }
        }
        if (isset($map['ccPosition'])) {
            $model->ccPosition = $map['ccPosition'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['formComponentValues'])) {
            if (!empty($map['formComponentValues'])) {
                $model->formComponentValues = [];
                $n                          = 0;
                foreach ($map['formComponentValues'] as $item) {
                    $model->formComponentValues[$n++] = null !== $item ? formComponentValues::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['microappAgentId'])) {
            $model->microappAgentId = $map['microappAgentId'];
        }
        if (isset($map['originatorUserId'])) {
            $model->originatorUserId = $map['originatorUserId'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['targetSelectActioners'])) {
            if (!empty($map['targetSelectActioners'])) {
                $model->targetSelectActioners = [];
                $n                            = 0;
                foreach ($map['targetSelectActioners'] as $item) {
                    $model->targetSelectActioners[$n++] = null !== $item ? targetSelectActioners::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
