<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardWithDelegateRequest\imGroupOpenSpaceModel;

use AlibabaCloud\Tea\Model;

class notification extends Model
{
    /**
     * @example 你收到1条新消息
     *
     * @var string
     */
    public $alertContent;

    /**
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
