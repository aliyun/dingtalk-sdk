<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoResponseBody\confInfo;

use AlibabaCloud\Tea\Model;

class extensionAppSettings extends Model
{
    /**
     * @var string
     */
    public $appCode;

    /**
     * @var string
     */
    public $appId;

    /**
     * @var int
     */
    public $autoOpenMode;

    /**
     * @var string
     */
    public $extensionAppBizData;
    protected $_name = [
        'appCode' => 'appCode',
        'appId' => 'appId',
        'autoOpenMode' => 'autoOpenMode',
        'extensionAppBizData' => 'extensionAppBizData',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appCode) {
            $res['appCode'] = $this->appCode;
        }
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->autoOpenMode) {
            $res['autoOpenMode'] = $this->autoOpenMode;
        }
        if (null !== $this->extensionAppBizData) {
            $res['extensionAppBizData'] = $this->extensionAppBizData;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return extensionAppSettings
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appCode'])) {
            $model->appCode = $map['appCode'];
        }
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['autoOpenMode'])) {
            $model->autoOpenMode = $map['autoOpenMode'];
        }
        if (isset($map['extensionAppBizData'])) {
            $model->extensionAppBizData = $map['extensionAppBizData'];
        }

        return $model;
    }
}
