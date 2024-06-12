<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryMinutesSummaryRequest extends Model
{
    /**
     * @var string[]
     */
    public $summaryTypeList;

    /**
     * @description This parameter is required.
     *
     * @example 27SaQ3iiHLN0uwqcPisedfreNwiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'summaryTypeList' => 'summaryTypeList',
        'unionId'         => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->summaryTypeList) {
            $res['summaryTypeList'] = $this->summaryTypeList;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryMinutesSummaryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['summaryTypeList'])) {
            if (!empty($map['summaryTypeList'])) {
                $model->summaryTypeList = $map['summaryTypeList'];
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
