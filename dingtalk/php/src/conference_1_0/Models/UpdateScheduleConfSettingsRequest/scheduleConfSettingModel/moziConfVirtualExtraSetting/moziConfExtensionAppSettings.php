<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateScheduleConfSettingsRequest\scheduleConfSettingModel\moziConfVirtualExtraSetting;

use AlibabaCloud\Tea\Model;

class moziConfExtensionAppSettings extends Model
{
    /**
     * @example 0：不自动打开 1：仅主持人/联席主持人自动打开 2：全员自动打开
     *
     * @var int
     */
    public $autoOpenMode;

    /**
     * @example COOLAPP-0-1026633886192127xxxB000W
     *
     * @var string
     */
    public $coolAppCode;

    /**
     * @example bizData
     *
     * @var string
     */
    public $extensionAppBizData;
    protected $_name = [
        'autoOpenMode' => 'autoOpenMode',
        'coolAppCode' => 'coolAppCode',
        'extensionAppBizData' => 'extensionAppBizData',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->autoOpenMode) {
            $res['autoOpenMode'] = $this->autoOpenMode;
        }
        if (null !== $this->coolAppCode) {
            $res['coolAppCode'] = $this->coolAppCode;
        }
        if (null !== $this->extensionAppBizData) {
            $res['extensionAppBizData'] = $this->extensionAppBizData;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return moziConfExtensionAppSettings
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['autoOpenMode'])) {
            $model->autoOpenMode = $map['autoOpenMode'];
        }
        if (isset($map['coolAppCode'])) {
            $model->coolAppCode = $map['coolAppCode'];
        }
        if (isset($map['extensionAppBizData'])) {
            $model->extensionAppBizData = $map['extensionAppBizData'];
        }

        return $model;
    }
}
