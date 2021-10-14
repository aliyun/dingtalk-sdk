<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryBatchTradeOrderRequest extends Model
{
    /**
     * @description ISV/企业自建应用suiteId
     *
     * @var string
     */
    public $suiteId;

    /**
     * @description ISV的cropId
     *
     * @var string
     */
    public $isvCorpId;

    /**
     * @description 外部商户批次号列表
     *
     * @var string[]
     */
    public $outBatchNos;
    protected $_name = [
        'suiteId'     => 'suiteId',
        'isvCorpId'   => 'isvCorpId',
        'outBatchNos' => 'outBatchNos',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->suiteId) {
            $res['suiteId'] = $this->suiteId;
        }
        if (null !== $this->isvCorpId) {
            $res['isvCorpId'] = $this->isvCorpId;
        }
        if (null !== $this->outBatchNos) {
            $res['outBatchNos'] = $this->outBatchNos;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBatchTradeOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['suiteId'])) {
            $model->suiteId = $map['suiteId'];
        }
        if (isset($map['isvCorpId'])) {
            $model->isvCorpId = $map['isvCorpId'];
        }
        if (isset($map['outBatchNos'])) {
            if (!empty($map['outBatchNos'])) {
                $model->outBatchNos = $map['outBatchNos'];
            }
        }

        return $model;
    }
}
