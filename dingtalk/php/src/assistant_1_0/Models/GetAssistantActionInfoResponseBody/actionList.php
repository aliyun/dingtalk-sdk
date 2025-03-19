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
    public $actionName;

    /**
     * @var string
     */
    public $actionVersion;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $icon;
    protected $_name = [
        'actionId' => 'actionId',
        'actionName' => 'actionName',
        'actionVersion' => 'actionVersion',
        'description' => 'description',
        'icon' => 'icon',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionId) {
            $res['actionId'] = $this->actionId;
        }
        if (null !== $this->actionName) {
            $res['actionName'] = $this->actionName;
        }
        if (null !== $this->actionVersion) {
            $res['actionVersion'] = $this->actionVersion;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
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
        if (isset($map['actionName'])) {
            $model->actionName = $map['actionName'];
        }
        if (isset($map['actionVersion'])) {
            $model->actionVersion = $map['actionVersion'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }

        return $model;
    }
}
