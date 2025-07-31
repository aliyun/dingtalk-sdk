<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeployAssistantRequest;

use AlibabaCloud\Tea\Model;

class fallback extends Model
{
    /**
     * @var string
     */
    public $actionType;

    /**
     * @var string
     */
    public $defaultMsg;
    protected $_name = [
        'actionType' => 'actionType',
        'defaultMsg' => 'defaultMsg',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionType) {
            $res['actionType'] = $this->actionType;
        }
        if (null !== $this->defaultMsg) {
            $res['defaultMsg'] = $this->defaultMsg;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fallback
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionType'])) {
            $model->actionType = $map['actionType'];
        }
        if (isset($map['defaultMsg'])) {
            $model->defaultMsg = $map['defaultMsg'];
        }

        return $model;
    }
}
