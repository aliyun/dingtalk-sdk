<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetGeneralFormCreatedSummaryResponseBody extends Model
{
    /**
     * @description 最近1天智能填表创建数
     *
     * @var string
     */
    public $generalFormCreatedCnt;

    /**
     * @description 最近1天使用智能填表人数
     *
     * @var string
     */
    public $useGeneralFormUserCnt1d;
    protected $_name = [
        'generalFormCreatedCnt'   => 'generalFormCreatedCnt',
        'useGeneralFormUserCnt1d' => 'useGeneralFormUserCnt1d',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->generalFormCreatedCnt) {
            $res['generalFormCreatedCnt'] = $this->generalFormCreatedCnt;
        }
        if (null !== $this->useGeneralFormUserCnt1d) {
            $res['useGeneralFormUserCnt1d'] = $this->useGeneralFormUserCnt1d;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetGeneralFormCreatedSummaryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['generalFormCreatedCnt'])) {
            $model->generalFormCreatedCnt = $map['generalFormCreatedCnt'];
        }
        if (isset($map['useGeneralFormUserCnt1d'])) {
            $model->useGeneralFormUserCnt1d = $map['useGeneralFormUserCnt1d'];
        }

        return $model;
    }
}
