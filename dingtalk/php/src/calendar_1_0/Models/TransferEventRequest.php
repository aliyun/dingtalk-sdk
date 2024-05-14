<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class TransferEventRequest extends Model
{
    /**
     * @var bool
     */
    public $isExitCalendar;

    /**
     * @var bool
     */
    public $needNotifyViaO2O;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $newOrganizerId;
    protected $_name = [
        'isExitCalendar'   => 'isExitCalendar',
        'needNotifyViaO2O' => 'needNotifyViaO2O',
        'newOrganizerId'   => 'newOrganizerId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isExitCalendar) {
            $res['isExitCalendar'] = $this->isExitCalendar;
        }
        if (null !== $this->needNotifyViaO2O) {
            $res['needNotifyViaO2O'] = $this->needNotifyViaO2O;
        }
        if (null !== $this->newOrganizerId) {
            $res['newOrganizerId'] = $this->newOrganizerId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TransferEventRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isExitCalendar'])) {
            $model->isExitCalendar = $map['isExitCalendar'];
        }
        if (isset($map['needNotifyViaO2O'])) {
            $model->needNotifyViaO2O = $map['needNotifyViaO2O'];
        }
        if (isset($map['newOrganizerId'])) {
            $model->newOrganizerId = $map['newOrganizerId'];
        }

        return $model;
    }
}
