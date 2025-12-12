<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\ExportMinutesTaskResultRequest\summaryExportSetting;
use AlibabaCloud\Tea\Model;

class ExportMinutesTaskResultRequest extends Model
{
    /**
     * @var int
     */
    public $expireTime;

    /**
     * @var summaryExportSetting
     */
    public $summaryExportSetting;

    /**
     * @description This parameter is required.
     *
     * @example text
     *
     * @var string
     */
    public $taskType;

    /**
     * @description This parameter is required.
     *
     * @example 763xxxxxx325f32
     *
     * @var string
     */
    public $taskUuid;

    /**
     * @description This parameter is required.
     *
     * @example D5xxxxxxxxxxxxxxEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'expireTime' => 'expireTime',
        'summaryExportSetting' => 'summaryExportSetting',
        'taskType' => 'taskType',
        'taskUuid' => 'taskUuid',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->expireTime) {
            $res['expireTime'] = $this->expireTime;
        }
        if (null !== $this->summaryExportSetting) {
            $res['summaryExportSetting'] = null !== $this->summaryExportSetting ? $this->summaryExportSetting->toMap() : null;
        }
        if (null !== $this->taskType) {
            $res['taskType'] = $this->taskType;
        }
        if (null !== $this->taskUuid) {
            $res['taskUuid'] = $this->taskUuid;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExportMinutesTaskResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['expireTime'])) {
            $model->expireTime = $map['expireTime'];
        }
        if (isset($map['summaryExportSetting'])) {
            $model->summaryExportSetting = summaryExportSetting::fromMap($map['summaryExportSetting']);
        }
        if (isset($map['taskType'])) {
            $model->taskType = $map['taskType'];
        }
        if (isset($map['taskUuid'])) {
            $model->taskUuid = $map['taskUuid'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
