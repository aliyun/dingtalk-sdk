<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteEventRequest extends Model
{
    /**
     * @var bool
     */
    public $pushNotification;
    protected $_name = [
        'pushNotification' => 'pushNotification',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pushNotification) {
            $res['pushNotification'] = $this->pushNotification;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteEventRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pushNotification'])) {
            $model->pushNotification = $map['pushNotification'];
        }

        return $model;
    }
}
