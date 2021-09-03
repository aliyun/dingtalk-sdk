<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetGeneralFormCreatedSummaryResponseBody extends Model
{
    /**
     * @description 最近1天累计智能填表创建数
     *
     * @var string
     */
    public $generalFormCreatedCnt;
    protected $_name = [
        'generalFormCreatedCnt' => 'generalFormCreatedCnt',
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

        return $model;
    }
}
