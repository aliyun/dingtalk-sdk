<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryPaymentBenefitResponseBody extends Model
{
    /**
     * @var BenefitMapValue[]
     */
    public $benefitMap;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $requestId;
    protected $_name = [
        'benefitMap' => 'benefitMap',
        'corpId' => 'corpId',
        'requestId' => 'requestId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->benefitMap) {
            $res['benefitMap'] = [];
            if (null !== $this->benefitMap && \is_array($this->benefitMap)) {
                foreach ($this->benefitMap as $key => $val) {
                    $res['benefitMap'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryPaymentBenefitResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['benefitMap'])) {
            $model->benefitMap = $map['benefitMap'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }

        return $model;
    }
}
