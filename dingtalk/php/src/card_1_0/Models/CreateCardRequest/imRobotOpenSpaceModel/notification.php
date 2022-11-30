<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardRequest\imRobotOpenSpaceModel;

use AlibabaCloud\Tea\Model;

class notification extends Model
{
    /**
     * @description 【条件必填】通知内容
     * 若不填写则使用默认文案：如你收到1条新消息
     * @var string
     */
    public $alertContent;

    /**
     * @description 是否推送通知，默认为 false
     *
     * @var bool
     */
    public $notificationOff;
    protected $_name = [
        'alertContent'    => 'alertContent',
        'notificationOff' => 'notificationOff',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->alertContent) {
            $res['alertContent'] = $this->alertContent;
        }
        if (null !== $this->notificationOff) {
            $res['notificationOff'] = $this->notificationOff;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return notification
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['alertContent'])) {
            $model->alertContent = $map['alertContent'];
        }
        if (isset($map['notificationOff'])) {
            $model->notificationOff = $map['notificationOff'];
        }

        return $model;
    }
}
