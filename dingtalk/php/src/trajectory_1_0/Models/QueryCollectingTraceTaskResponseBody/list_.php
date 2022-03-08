<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryCollectingTraceTaskResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 应用轨迹ID
     *
     * @var string
     */
    public $appTraceId;

    /**
     * @var int
     */
    public $geoCollectPeriod;

    /**
     * @var int
     */
    public $geoReportPeriod;

    /**
     * @var int
     */
    public $geoReportStatus;

    /**
     * @var int
     */
    public $reportEndTime;

    /**
     * @var int
     */
    public $reportStartTime;

    /**
     * @description 组织下员工Id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appTraceId'       => 'appTraceId',
        'geoCollectPeriod' => 'geoCollectPeriod',
        'geoReportPeriod'  => 'geoReportPeriod',
        'geoReportStatus'  => 'geoReportStatus',
        'reportEndTime'    => 'reportEndTime',
        'reportStartTime'  => 'reportStartTime',
        'userId'           => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appTraceId) {
            $res['appTraceId'] = $this->appTraceId;
        }
        if (null !== $this->geoCollectPeriod) {
            $res['geoCollectPeriod'] = $this->geoCollectPeriod;
        }
        if (null !== $this->geoReportPeriod) {
            $res['geoReportPeriod'] = $this->geoReportPeriod;
        }
        if (null !== $this->geoReportStatus) {
            $res['geoReportStatus'] = $this->geoReportStatus;
        }
        if (null !== $this->reportEndTime) {
            $res['reportEndTime'] = $this->reportEndTime;
        }
        if (null !== $this->reportStartTime) {
            $res['reportStartTime'] = $this->reportStartTime;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appTraceId'])) {
            $model->appTraceId = $map['appTraceId'];
        }
        if (isset($map['geoCollectPeriod'])) {
            $model->geoCollectPeriod = $map['geoCollectPeriod'];
        }
        if (isset($map['geoReportPeriod'])) {
            $model->geoReportPeriod = $map['geoReportPeriod'];
        }
        if (isset($map['geoReportStatus'])) {
            $model->geoReportStatus = $map['geoReportStatus'];
        }
        if (isset($map['reportEndTime'])) {
            $model->reportEndTime = $map['reportEndTime'];
        }
        if (isset($map['reportStartTime'])) {
            $model->reportStartTime = $map['reportStartTime'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
