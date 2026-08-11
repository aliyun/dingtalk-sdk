<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\AnalyzeSubjectTransactionRiskResponseBody\result\historyCooperation;

use AlibabaCloud\Tea\Model;

class incomeAmounts extends Model
{
    /**
     * @var string
     */
    public $cNY;

    /**
     * @var string
     */
    public $uSD;
    protected $_name = [
        'cNY' => 'cNY',
        'uSD' => 'uSD',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->cNY) {
            $res['cNY'] = $this->cNY;
        }
        if (null !== $this->uSD) {
            $res['uSD'] = $this->uSD;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return incomeAmounts
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cNY'])) {
            $model->cNY = $map['cNY'];
        }
        if (isset($map['uSD'])) {
            $model->uSD = $map['uSD'];
        }

        return $model;
    }
}
