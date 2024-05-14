<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryCollectingTraceTaskResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example ffsfsdf
     *
     * @var string
     */
    public $appTraceId;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $geoCollectPeriod;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $geoReportPeriod;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $geoReportStatus;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $reportEndTime;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $reportStartTime;

    /**
     * @description This parameter is required.
     *
     * @example I01231231ads1
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
