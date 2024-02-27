<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SpecialRuleBatchReceiverRequest\data;
use AlibabaCloud\Tea\Model;

class SpecialRuleBatchReceiverRequest extends Model
{
    /**
     * @var string
     */
    public $batchNo;

    /**
     * @var string
     */
    public $cardOptions;

    /**
     * @var data[]
     */
    public $data;

    /**
     * @var string
     */
    public $ruleCode;

    /**
     * @var string
     */
    public $secretKey;

    /**
     * @var bool
     */
    public $specialStrategy;

    /**
     * @var string
     */
    public $taskBatchNo;
    protected $_name = [
        'batchNo'         => 'batchNo',
        'cardOptions'     => 'cardOptions',
        'data'            => 'data',
        'ruleCode'        => 'ruleCode',
        'secretKey'       => 'secretKey',
        'specialStrategy' => 'specialStrategy',
        'taskBatchNo'     => 'taskBatchNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->batchNo) {
            $res['batchNo'] = $this->batchNo;
        }
        if (null !== $this->cardOptions) {
            $res['cardOptions'] = $this->cardOptions;
        }
        if (null !== $this->data) {
            $res['data'] = [];
            if (null !== $this->data && \is_array($this->data)) {
                $n = 0;
                foreach ($this->data as $item) {
                    $res['data'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->ruleCode) {
            $res['ruleCode'] = $this->ruleCode;
        }
        if (null !== $this->secretKey) {
            $res['secretKey'] = $this->secretKey;
        }
        if (null !== $this->specialStrategy) {
            $res['specialStrategy'] = $this->specialStrategy;
        }
        if (null !== $this->taskBatchNo) {
            $res['taskBatchNo'] = $this->taskBatchNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SpecialRuleBatchReceiverRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['batchNo'])) {
            $model->batchNo = $map['batchNo'];
        }
        if (isset($map['cardOptions'])) {
            $model->cardOptions = $map['cardOptions'];
        }
        if (isset($map['data'])) {
            if (!empty($map['data'])) {
                $model->data = [];
                $n           = 0;
                foreach ($map['data'] as $item) {
                    $model->data[$n++] = null !== $item ? data::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['ruleCode'])) {
            $model->ruleCode = $map['ruleCode'];
        }
        if (isset($map['secretKey'])) {
            $model->secretKey = $map['secretKey'];
        }
        if (isset($map['specialStrategy'])) {
            $model->specialStrategy = $map['specialStrategy'];
        }
        if (isset($map['taskBatchNo'])) {
            $model->taskBatchNo = $map['taskBatchNo'];
        }

        return $model;
    }
}
