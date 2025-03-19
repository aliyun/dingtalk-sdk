<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryScheduleConfSettingsResponseBody\scheduleConfSettingModel\moziConfVirtualExtraSetting;

use AlibabaCloud\Tea\Model;

class moziConfExtensionAppSettings extends Model
{
    /**
     * @var string
     */
    public $autoOpenMode;

    /**
     * @var string
     */
    public $clientId;

    /**
     * @var string
     */
    public $coolAppCode;

    /**
     * @var string
     */
    public $extensionAppBizData;
    protected $_name = [
        'autoOpenMode' => 'autoOpenMode',
        'clientId' => 'clientId',
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
        if (null !== $this->clientId) {
            $res['clientId'] = $this->clientId;
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
        if (isset($map['clientId'])) {
            $model->clientId = $map['clientId'];
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
