<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumUpdateProcessInstanceVariablesRequest\variables;
use AlibabaCloud\Tea\Model;

class PremiumUpdateProcessInstanceVariablesRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example manager432
     *
     * @var string
     */
    public $opUserId;

    /**
     * @example PROC-EF6YJL35P2-SCKICSB7P750S0YISYKV3-xxxx-1
     *
     * @var string
     */
    public $processCode;

    /**
     * @description This parameter is required.
     *
     * @example processInstanceId-1
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @example processInstanceId-1
     *
     * @var string
     */
    public $remark;

    /**
     * @description This parameter is required.
     *
     * @var variables[]
     */
    public $variables;
    protected $_name = [
        'opUserId'          => 'opUserId',
        'processCode'       => 'processCode',
        'processInstanceId' => 'processInstanceId',
        'remark'            => 'remark',
        'variables'         => 'variables',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->variables) {
            $res['variables'] = [];
            if (null !== $this->variables && \is_array($this->variables)) {
                $n = 0;
                foreach ($this->variables as $item) {
                    $res['variables'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PremiumUpdateProcessInstanceVariablesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['variables'])) {
            if (!empty($map['variables'])) {
                $model->variables = [];
                $n                = 0;
                foreach ($map['variables'] as $item) {
                    $model->variables[$n++] = null !== $item ? variables::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
