<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryReportDetailRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 18XXXX
     *
     * @var string
     */
    public $reportId;
    protected $_name = [
        'reportId' => 'reportId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->reportId) {
            $res['reportId'] = $this->reportId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryReportDetailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['reportId'])) {
            $model->reportId = $map['reportId'];
        }

        return $model;
    }
}
