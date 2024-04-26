<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryScheduleConfSettingsResponseBody\scheduleConfSettingModel;
use AlibabaCloud\Tea\Model;

class QueryScheduleConfSettingsResponseBody extends Model
{
    /**
     * @var scheduleConfSettingModel
     */
    public $scheduleConfSettingModel;
    protected $_name = [
        'scheduleConfSettingModel' => 'scheduleConfSettingModel',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->scheduleConfSettingModel) {
            $res['scheduleConfSettingModel'] = null !== $this->scheduleConfSettingModel ? $this->scheduleConfSettingModel->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryScheduleConfSettingsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['scheduleConfSettingModel'])) {
            $model->scheduleConfSettingModel = scheduleConfSettingModel::fromMap($map['scheduleConfSettingModel']);
        }

        return $model;
    }
}
