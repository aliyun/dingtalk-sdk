<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateScheduleConfSettingsRequest\scheduleConfSettingModel;
use AlibabaCloud\Tea\Model;

class UpdateScheduleConfSettingsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
     *
     * @var string
     */
    public $creatorUnionId;

    /**
     * @var scheduleConfSettingModel
     */
    public $scheduleConfSettingModel;

    /**
     * @description This parameter is required.
     *
     * @example f6fb627e-a7e8-403e-b1f8-26e85450f4a9
     *
     * @var string
     */
    public $scheduleConferenceId;
    protected $_name = [
        'creatorUnionId' => 'creatorUnionId',
        'scheduleConfSettingModel' => 'scheduleConfSettingModel',
        'scheduleConferenceId' => 'scheduleConferenceId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
        }
        if (null !== $this->scheduleConfSettingModel) {
            $res['scheduleConfSettingModel'] = null !== $this->scheduleConfSettingModel ? $this->scheduleConfSettingModel->toMap() : null;
        }
        if (null !== $this->scheduleConferenceId) {
            $res['scheduleConferenceId'] = $this->scheduleConferenceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateScheduleConfSettingsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
        }
        if (isset($map['scheduleConfSettingModel'])) {
            $model->scheduleConfSettingModel = scheduleConfSettingModel::fromMap($map['scheduleConfSettingModel']);
        }
        if (isset($map['scheduleConferenceId'])) {
            $model->scheduleConferenceId = $map['scheduleConferenceId'];
        }

        return $model;
    }
}
