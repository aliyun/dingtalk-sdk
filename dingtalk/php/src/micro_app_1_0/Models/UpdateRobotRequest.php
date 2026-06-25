<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateRobotRequest extends Model
{
    /**
     * @var string
     */
    public $brief;

    /**
     * @var string
     */
    public $chatBotEventUrl;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $iconMediaId;

    /**
     * @var int
     */
    public $mode;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $outgoingUrl;

    /**
     * @var string
     */
    public $unifiedAppId;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'brief' => 'brief',
        'chatBotEventUrl' => 'chatBotEventUrl',
        'description' => 'description',
        'iconMediaId' => 'iconMediaId',
        'mode' => 'mode',
        'name' => 'name',
        'outgoingUrl' => 'outgoingUrl',
        'unifiedAppId' => 'unifiedAppId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->brief) {
            $res['brief'] = $this->brief;
        }
        if (null !== $this->chatBotEventUrl) {
            $res['chatBotEventUrl'] = $this->chatBotEventUrl;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->iconMediaId) {
            $res['iconMediaId'] = $this->iconMediaId;
        }
        if (null !== $this->mode) {
            $res['mode'] = $this->mode;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->outgoingUrl) {
            $res['outgoingUrl'] = $this->outgoingUrl;
        }
        if (null !== $this->unifiedAppId) {
            $res['unifiedAppId'] = $this->unifiedAppId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateRobotRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['brief'])) {
            $model->brief = $map['brief'];
        }
        if (isset($map['chatBotEventUrl'])) {
            $model->chatBotEventUrl = $map['chatBotEventUrl'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['iconMediaId'])) {
            $model->iconMediaId = $map['iconMediaId'];
        }
        if (isset($map['mode'])) {
            $model->mode = $map['mode'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['outgoingUrl'])) {
            $model->outgoingUrl = $map['outgoingUrl'];
        }
        if (isset($map['unifiedAppId'])) {
            $model->unifiedAppId = $map['unifiedAppId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
