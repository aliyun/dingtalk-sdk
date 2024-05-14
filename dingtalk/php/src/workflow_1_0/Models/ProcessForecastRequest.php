<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastRequest\formComponentValues;
use AlibabaCloud\Tea\Model;

class ProcessForecastRequest extends Model
{
    /**
     * @description This parameter is required.
     *
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
     * @description This parameter is required.
     *
     * @example PROC-EF6YJL35P2-SCKICSB7P750S0YISYKV3-xxxx-1
     *
     * @var string
     */
    public $processCode;

    /**
     * @description This parameter is required.
     *
     * @example manager432
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'deptId'              => 'deptId',
        'formComponentValues' => 'formComponentValues',
        'processCode'         => 'processCode',
        'userId'              => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ProcessForecastRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
