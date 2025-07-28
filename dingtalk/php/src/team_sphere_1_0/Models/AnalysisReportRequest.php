<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\AnalysisReportRequest\filter;
use AlibabaCloud\Tea\Model;

class AnalysisReportRequest extends Model
{
    /**
     * @var filter
     */
    public $filter;

    /**
     * @var string
     */
    public $reportId;
    protected $_name = [
        'filter' => 'filter',
        'reportId' => 'reportId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->filter) {
            $res['filter'] = null !== $this->filter ? $this->filter->toMap() : null;
        }
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
        if (isset($map['filter'])) {
            $model->filter = filter::fromMap($map['filter']);
        }
        if (isset($map['reportId'])) {
            $model->reportId = $map['reportId'];
        }

        return $model;
    }
}
