<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateScheduleConfSettingsRequest\scheduleConfSettingModel;

use AlibabaCloud\Tea\Model;

class aiAgentSummarySetting extends Model
{
    /**
     * @var int
     */
    public $allowAllParticipantsStart;

    /**
     * @var int
     */
    public $receiverType;

    /**
     * @var int
     */
    public $restrictShareMinutesSummaryOnly;

    /**
     * @var string
     */
    public $value;
    protected $_name = [
        'allowAllParticipantsStart' => 'allowAllParticipantsStart',
        'receiverType' => 'receiverType',
        'restrictShareMinutesSummaryOnly' => 'restrictShareMinutesSummaryOnly',
        'value' => 'value',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->allowAllParticipantsStart) {
            $res['allowAllParticipantsStart'] = $this->allowAllParticipantsStart;
        }
        if (null !== $this->receiverType) {
            $res['receiverType'] = $this->receiverType;
        }
        if (null !== $this->restrictShareMinutesSummaryOnly) {
            $res['restrictShareMinutesSummaryOnly'] = $this->restrictShareMinutesSummaryOnly;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return aiAgentSummarySetting
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allowAllParticipantsStart'])) {
            $model->allowAllParticipantsStart = $map['allowAllParticipantsStart'];
        }
        if (isset($map['receiverType'])) {
            $model->receiverType = $map['receiverType'];
        }
        if (isset($map['restrictShareMinutesSummaryOnly'])) {
            $model->restrictShareMinutesSummaryOnly = $map['restrictShareMinutesSummaryOnly'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
