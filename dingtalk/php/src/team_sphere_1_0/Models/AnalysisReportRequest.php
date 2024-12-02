<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models;

use AlibabaCloud\Tea\Model;

class AnalysisReportRequest extends Model
{
    /**
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
     * @return AnalysisReportRequest
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
