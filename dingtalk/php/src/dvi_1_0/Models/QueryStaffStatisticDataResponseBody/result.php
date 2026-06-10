<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryStaffStatisticDataResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var float
     */
    public $averageQualityInspectionScorePerService;

    /**
     * @var string
     */
    public $day;

    /**
     * @var float
     */
    public $highestQualityInspectionScore;

    /**
     * @var mixed[]
     */
    public $saleSopPercentage;

    /**
     * @var int
     */
    public $serviceRecordCount;

    /**
     * @var string
     */
    public $staffName;

    /**
     * @var string
     */
    public $teamCode;

    /**
     * @var string
     */
    public $teamName;

    /**
     * @var int
     */
    public $totalServiceTime;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'averageQualityInspectionScorePerService' => 'averageQualityInspectionScorePerService',
        'day' => 'day',
        'highestQualityInspectionScore' => 'highestQualityInspectionScore',
        'saleSopPercentage' => 'saleSopPercentage',
        'serviceRecordCount' => 'serviceRecordCount',
        'staffName' => 'staffName',
        'teamCode' => 'teamCode',
        'teamName' => 'teamName',
        'totalServiceTime' => 'totalServiceTime',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->averageQualityInspectionScorePerService) {
            $res['averageQualityInspectionScorePerService'] = $this->averageQualityInspectionScorePerService;
        }
        if (null !== $this->day) {
            $res['day'] = $this->day;
        }
        if (null !== $this->highestQualityInspectionScore) {
            $res['highestQualityInspectionScore'] = $this->highestQualityInspectionScore;
        }
        if (null !== $this->saleSopPercentage) {
            $res['saleSopPercentage'] = $this->saleSopPercentage;
        }
        if (null !== $this->serviceRecordCount) {
            $res['serviceRecordCount'] = $this->serviceRecordCount;
        }
        if (null !== $this->staffName) {
            $res['staffName'] = $this->staffName;
        }
        if (null !== $this->teamCode) {
            $res['teamCode'] = $this->teamCode;
        }
        if (null !== $this->teamName) {
            $res['teamName'] = $this->teamName;
        }
        if (null !== $this->totalServiceTime) {
            $res['totalServiceTime'] = $this->totalServiceTime;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['averageQualityInspectionScorePerService'])) {
            $model->averageQualityInspectionScorePerService = $map['averageQualityInspectionScorePerService'];
        }
        if (isset($map['day'])) {
            $model->day = $map['day'];
        }
        if (isset($map['highestQualityInspectionScore'])) {
            $model->highestQualityInspectionScore = $map['highestQualityInspectionScore'];
        }
        if (isset($map['saleSopPercentage'])) {
            $model->saleSopPercentage = $map['saleSopPercentage'];
        }
        if (isset($map['serviceRecordCount'])) {
            $model->serviceRecordCount = $map['serviceRecordCount'];
        }
        if (isset($map['staffName'])) {
            $model->staffName = $map['staffName'];
        }
        if (isset($map['teamCode'])) {
            $model->teamCode = $map['teamCode'];
        }
        if (isset($map['teamName'])) {
            $model->teamName = $map['teamName'];
        }
        if (isset($map['totalServiceTime'])) {
            $model->totalServiceTime = $map['totalServiceTime'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
