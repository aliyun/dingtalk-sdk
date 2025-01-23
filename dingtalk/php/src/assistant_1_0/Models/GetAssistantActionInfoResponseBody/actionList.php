<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\GetAssistantActionInfoResponseBody;

use AlibabaCloud\Tea\Model;

class actionList extends Model
{
    /**
     * @var string
     */
    public $actionId;

    /**
     * @var string
     */
    public $actionVersion;
    protected $_name = [
        'actionId'      => 'actionId',
        'actionVersion' => 'actionVersion',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionId) {
            $res['actionId'] = $this->actionId;
        }
        if (null !== $this->actionVersion) {
            $res['actionVersion'] = $this->actionVersion;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return actionList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionId'])) {
            $model->actionId = $map['actionId'];
        }
        if (isset($map['actionVersion'])) {
            $model->actionVersion = $map['actionVersion'];
        }

        return $model;
    }
}
