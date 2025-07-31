<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeployAssistantRequest\action;

use AlibabaCloud\Tea\Model;

class actionAuthInfo extends Model
{
    /**
     * @var string
     */
    public $authConfig;

    /**
     * @var string
     */
    public $authenticationType;
    protected $_name = [
        'authConfig' => 'authConfig',
        'authenticationType' => 'authenticationType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->authConfig) {
            $res['authConfig'] = $this->authConfig;
        }
        if (null !== $this->authenticationType) {
            $res['authenticationType'] = $this->authenticationType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return actionAuthInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authConfig'])) {
            $model->authConfig = $map['authConfig'];
        }
        if (isset($map['authenticationType'])) {
            $model->authenticationType = $map['authenticationType'];
        }

        return $model;
    }
}
